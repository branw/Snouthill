using System.Buffers;
using System.IO.Pipelines;
using System.Net;
using System.Net.Sockets;
using Serilog;

namespace Snouthill.Networking;

public delegate void PacketProcessor(ref ReadOnlySequence<byte> buffer);

public class Connection : IDisposable
{
    private static int _lastId;

    private readonly Task<Task> _listenerTask;
    private readonly Socket _socket;

    public PacketProcessor? OnDataReceived;

    public Connection(Socket socket)
    {
        Id = Interlocked.Increment(ref _lastId);
        _socket = socket;

        Connected = true;

        // Start polling for data
        _listenerTask = Task.Factory.StartNew(async () =>
        {
            var pipe = new Pipe();

            await Task.WhenAll(
                FillPipeAsync(pipe.Writer),
                ReadPipeAsync(pipe.Reader));
        });
    }

    public int Id { get; }
    public bool Connected { get; internal set; }

    public IPAddress? EndPoint => ((IPEndPoint?) _socket.RemoteEndPoint)?.Address;

    public void Dispose()
    {
        GC.SuppressFinalize(this);

        if (!Connected) return;

        Log.Information("Client {Id} disconnected", Id);

        Connected = false;
        _listenerTask.Wait();
        _socket.Shutdown(SocketShutdown.Both);
        _socket.Close();
    }

    // Reads from the socket and writes to the pipe
    private async Task FillPipeAsync(PipeWriter writer)
    {
        while (Connected)
        {
            try
            {
                var memory = writer.GetMemory();
                var bytesRead = await _socket.ReceiveAsync(memory, SocketFlags.None);
                if (bytesRead == 0) break;

                writer.Advance(bytesRead);
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to write to pipe");
                break;
            }

            var result = await writer.FlushAsync();
            if (result.IsCompleted) break;
        }

        await writer.CompleteAsync();

        Dispose();
    }

    // Reads from the pipe and processes packets
    private async Task ReadPipeAsync(PipeReader reader)
    {
        while (Connected)
        {
            ReadResult result;
            do
            {
                result = await reader.ReadAsync();

                var buffer = result.Buffer;
                OnDataReceived?.Invoke(ref buffer);
                reader.AdvanceTo(buffer.Start, buffer.End);
            } while (!result.IsCompleted);
        }

        await reader.CompleteAsync();
    }

    public void Send(ReadOnlySpan<byte> data)
    {
        if (!Connected)
            throw new InvalidOperationException("Client is not connected");

        var offset = 0;
        while (offset < data.Length)
        {
            var sent = _socket.Send(data[offset..]);
            if (sent == 0)
            {
                Dispose();
                return;
            }

            offset += sent;
        }
    }
}