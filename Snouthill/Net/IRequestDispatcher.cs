using Snouthill.Game;
using Snouthill.Net.Packets;

namespace Snouthill.Net;

public interface IRequestDispatcher
{
    public void EnsureLoaded();

    public IRequest? Deserialize(short opcode, PacketReader reader);

    public bool Handle(short opcode, IRequest request, Player player);
}