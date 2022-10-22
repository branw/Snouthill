namespace Snouthill.Networking.Messages.Handshake;

[Opcode(206)] // "INIT_CRYPTO"
public record InitCrypto : IInboundMessage<InitCrypto>
{
    public static InitCrypto Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(new CryptoParameters());
    }
}