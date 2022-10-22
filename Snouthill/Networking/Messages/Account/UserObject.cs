using Snouthill.Database.Models;
using Snouthill.Game;

namespace Snouthill.Networking.Messages.Account;

[Opcode(5)] // hh_entry/Login Handler/handleUserObj
public record UserObject(
    string Id,
    string Name,
    string Figure,
    string Sex,
    string Motto,
    int Tickets,
    string PoolFigure,
    int Film) : IOutboundMessage
{
    public UserObject(PlayerModel playerModel) : this(playerModel.Name, playerModel.Name, playerModel.Figure,
        playerModel.Sex, playerModel.Motto, playerModel.Tickets, playerModel.SwimsuitFigure, playerModel.Film)
    {
    }
 
    public UserObject(Player player) : this(player.Model)
    {
    }
    
    public void Serialize(PacketWriter message)
    {
        message.WriteString(Id); // tuser["user_id"]
        message.WriteString(Name); // tuser["name"]
        message.WriteString(Figure); // tuser["figure"]
        message.WriteString(Sex); // tuser["sex"]
        message.WriteString(Motto); // tuser["customData"]
        message.WriteInt(Tickets); // tuser["ph_tickets"]
        message.WriteString(PoolFigure); // tuser["ph_figure"]
        message.WriteInt(Film); // tuser["photo_film"]
        message.WriteInt(0); // tuser["directMail"]
    }
}