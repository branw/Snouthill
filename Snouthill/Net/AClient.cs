using System.Buffers;
using System.IO.Pipelines;
using System.Net.Sockets;
using Serilog;

namespace Snouthill.Net;

public abstract class AClient : IDisposable
{
    private readonly Task<Task> _listenerTask;

    private readonly Socket _socket;

    protected AClient(Socket socket)
    {
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

    public bool Connected { get; internal set; }

    public void Dispose()
    {
        GC.SuppressFinalize(this);

        if (!Connected) return;

        Connected = false;
        _listenerTask.Wait();
        _socket.Shutdown(SocketShutdown.Both);
        _socket.Close();
    }

    protected abstract void ProcessPackets(ref ReadOnlySequence<byte> buffer);

    public void Send(ReadOnlySpan<byte> data)
    {
        if (!Connected) return;

        var offset = 0;
        while (offset < data.Length)
        {
            var sent = _socket.Send(data[offset..]);
            if (sent == 0)
            {
                Disconnect();
                return;
            }

            offset += sent;
        }
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
                Disconnect();
                break;
            }

            var result = await writer.FlushAsync();
            if (result.IsCompleted) break;
        }

        await writer.CompleteAsync();
    }

    // Reads from the pipe and processes packets
    private async Task ReadPipeAsync(PipeReader reader)
    {
        try
        {
            while (Connected)
            {
                ReadResult result;
                do
                {
                    result = await reader.ReadAsync();

                    var buffer = result.Buffer;
                    ProcessPackets(ref buffer);
                    reader.AdvanceTo(buffer.Start, buffer.End);
                } while (Connected && !result.IsCompleted);
            }
        }
        catch (Exception e)
        {
            Log.Error(e, "Failed to read from pipe");
            Disconnect();
        }

        await reader.CompleteAsync();
    }

    public void Disconnect()
    {
        if (!Connected) return;

        Log.Information("Client disconnected");
        Dispose();
    }
}