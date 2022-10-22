namespace Snouthill.Networking.Messages;

public interface IHandleableMessage
{
    void Handle(Client client)
    {
    }
}

public interface IInboundMessage<out TDerived> : IHandleableMessage where TDerived : IInboundMessage<TDerived>
{
    static abstract TDerived Deserialize(PacketReader message);
}