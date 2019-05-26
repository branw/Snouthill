using Serilog;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Snouthill.Net
{
    public class ClientConnection : IDisposable
    {
        public bool Connected { get; internal set; }

        public int Port { get; internal set; }

        private readonly Socket _socket;
        private readonly Pipe _pipe;

        public delegate void OnPacketReceived(byte[] rawPacket);
        public event OnPacketReceived PacketReceived;

        public ClientConnection(Socket socket)
        {
            _socket = socket;
            _pipe = new Pipe();

            Connected = true;
            Port = ((IPEndPoint)socket?.LocalEndPoint).Port;

            // Start polling for data
            Task.Factory.StartNew(Listen);
        }

        private void ProcessPackets(ref ReadOnlySequence<byte> buffer, ref long dataRemaining)
        {
            // Keep parsing packets while there's enough data
            while (buffer.Length > 4)
            {
                var packetLengthStr = Encoding.ASCII.GetString(buffer.Slice(0, 4).ToArray());
                var packetLength = Convert.ToUInt32(packetLengthStr);
                if (packetLength > buffer.Length)
                {
                    break;
                }

                var packetData = buffer.Slice(4, packetLength).ToArray();
                PacketReceived?.Invoke(packetData);

                var next = buffer.GetPosition(4 + packetLength);
                buffer = buffer.Slice(next);
                dataRemaining = buffer.Length;
            }
        }

        public void Send(ReadOnlySpan<byte> data)
        {
            if (!Connected)
            {
                return;
            }

            var offset = 0;
            while (offset < data.Length)
            {
                var sent = _socket.Send(data.Slice(offset));
                if (sent == 0)
                {
                    Disconnect();
                    return;
                }

                offset += sent;
            }
        }

        private async Task Listen()
        {
            await Task.WhenAll(ReadAsync(), WriteAsync());
        }

        private async Task ReadAsync()
        {
            try
            {
                while (Connected)
                {
                    long dataRemaining = 0;
                    ReadResult result;
                    do
                    {
                        result = await _pipe.Reader.ReadAsync();

                        var buffer = result.Buffer;
                        ProcessPackets(ref buffer, ref dataRemaining);
                        _pipe.Reader.AdvanceTo(buffer.Start, buffer.End);
                    }
                    while (Connected && !result.IsCompleted);
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to read from pipe");
                Disconnect();
            }
        }

        private async Task WriteAsync()
        {
            while (Connected)
            {
                try
                {
                    var memory = _pipe.Writer.GetMemory();
                    var bytesRead = await _socket.ReceiveAsync(memory, SocketFlags.None);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    _pipe.Writer.Advance(bytesRead);
                }
                catch (Exception e)
                {
                    Log.Error(e, "Failed to write to pipe");
                    Disconnect();
                    break;
                }

                var result = await _pipe.Writer.FlushAsync();
                if (result.IsCompleted)
                {
                    break;
                }
            }
        }

        public void Disconnect()
        {
            if (!Connected)
            {
                return;
            }

            Log.Information("Client disconnected");
            Dispose();
        }

        public void Dispose()
        {
            if (!Connected)
            {
                return;
            }

            Connected = false;
            _pipe.Writer.Complete();
            _pipe.Reader.Complete();
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Close();
        }
    }
}
