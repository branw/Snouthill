using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Account;

[Opcode(7)] // "GET_INFO"/"INFORETRIEVE" in hh_registrat
public record GetInfo : IInboundMessage<GetInfo>
{
    public static GetInfo Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        client.Send(new UserObject(client.Player.Model));
    }
}