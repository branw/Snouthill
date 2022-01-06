namespace Snouthill.Net.Packets.Messenger;

[RequestOpcode(41)]
public record FindUserRequest(
    string Query) : IRequest;

public class FindUserRequestDeserializer : IRequestDeserializer<FindUserRequest>
{
    public FindUserRequest Deserialize(PacketReader reader)
    {
        var query = reader.ReadString();

        return new FindUserRequest(query);
    }
}