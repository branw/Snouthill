using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Outbound;

public record UserObject(
    string Id,
    string Name,
    string Figure,
    string Sex,
    string Motto,
    int Tickets,
    string PoolFigure,
    int Film) : IResponse
{
    public UserObject(PlayerModel playerModel) : this(playerModel.Name, playerModel.Name, playerModel.Figure,
        playerModel.Sex, playerModel.Motto, playerModel.Tickets, playerModel.SwimsuitFigure, playerModel.Film)
    {
    }

    public short Opcode => 5;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(Id);
        writer.WriteString(Name);
        writer.WriteString(Figure);
        writer.WriteString(Sex);
        writer.WriteString(Motto);
        writer.WriteInt(Tickets);
        writer.WriteString(PoolFigure);
        writer.WriteInt(Film);
    }
}