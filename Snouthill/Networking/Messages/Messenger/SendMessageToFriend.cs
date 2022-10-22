namespace Snouthill.Networking.Messages.Messenger;

// v1  MessengerScript/SendMessage
//     sendEPFuseMsg("MESSENGER_SENDMSG" && receivers & "\r" & message)
// v5  hh_messenger/Messenger Component
//     send(#info, "MESSENGER_SENDMSG" && tReceivers & "\r" & tMsg)
// v24 hh_instant_messenger/Instant Messenger Handler
//     tdata = [:]
//     tdata.addProp(#integer, integer(tReceiverID))
//     tdata.addProp(#string, tText)
//     send("MESSENGER_SENDMSG", tdata)
[Opcode(33)] // "MESSENGER_SENDMSG"
public record SendMessageToFriend : IInboundMessage<SendMessageToFriend>
{
    public static SendMessageToFriend Deserialize(PacketReader reader) => new();
}