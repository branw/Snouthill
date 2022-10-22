namespace Snouthill.Networking.Messages.Room;

[Opcode(182)] // "GETINTERST"
public record GetInterstitial(
    string? Type) : IInboundMessage<GetInterstitial>
{
    public static GetInterstitial Deserialize(PacketReader reader)
    {
        string? type = null;
        if (reader.Remaining > 0) type = reader.ReadRawString();

        return new GetInterstitial(type);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        client.Send(new InterstitialData("", ""));
    }
}