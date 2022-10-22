namespace Snouthill.Networking.Messages.Inbound;

[Opcode(58)] // "LANGCHECK"
public record LangCheckRequest(
    // From "lang_test_field"
    string Word) : IInboundMessage<LangCheckRequest>
{
    public static LangCheckRequest Deserialize(PacketReader reader)
    {
        var word = reader.ReadString();

        return new LangCheckRequest(word);
    }
}