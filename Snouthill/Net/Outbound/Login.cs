using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill.Net.Outbound
{
    class Hello : OutboundPacket
    {
        public override string Operation => "HELLO";
    }

    class NameApproved : OutboundPacket
    {
        public override string Operation => "NAME_APPROVED";
    }

    class NameUnacceptable : OutboundPacket
    {
        public override string Operation => "NAME_UNACCEPTABLE";
    }

    class NoSuchUser : OutboundPacket
    {
        public override string Operation => "NOSUCHUSER";
    }

    class EncryptionOn : OutboundPacket
    {
        public override string Operation => "ENCRYPTION_ON";
    }

    class EncryptionOff : OutboundPacket
    {
        public override string Operation => "ENCRYPTION_OFF";
    }

    class SecretKey : OutboundPacket
    {
        public override string Operation => "SECRET_KEY";

        [Property] public string Key { get; set; }

        public SecretKey(string key = "")
        {
            Key = key;
        }
    }
}
