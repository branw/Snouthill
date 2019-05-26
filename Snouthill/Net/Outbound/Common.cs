using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill.Net.Outbound
{
    class SystemBroadcast : OutboundPacket
    {
        public override string Operation => "SYSTEMBROADCAST";

        [Property(prefix: "\r")] public string Message { get; set; }

        public SystemBroadcast(string message = "")
        {
            Message = message;
        }
    }

    class WalletBalance : OutboundPacket
    {
        public override string Operation => "WALLETBALANCE";

        [Property] public int Credits { get; set; }
    }


}
