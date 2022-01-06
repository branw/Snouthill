using Serilog;

namespace Snouthill.Net.Packets.Outbound;

public record LocalizedError(LocalizedError.ErrorType Error) : IResponse
{
    public enum ErrorType
    {
        IncorrectPassword
    }

    public short Opcode => 33;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(Error switch
        {
            ErrorType.IncorrectPassword => "Login incorrect",
            _ => ((Func<string>) (() =>
            {
                Log.Error("Unknown localized error message {localizedError}", Error);
                return "";
            }))()
        });
    }
}