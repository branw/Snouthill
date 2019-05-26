using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill.Net.Outbound
{
    class UserObject : OutboundPacket
    {
        public override string Operation => "USEROBJECT";

        [Property(prefix: "\rname=")] public string Username { get; set; }
        [Property(prefix: "\rfigure=")] public string Figure { get; set; }
        [Property(prefix: "\remail=")] public string Email { get; set; }
        [Property(prefix: "\rbirthday=")] public string Birthday { get; set; }
        [Property(prefix: "\rphonenumber=")] public string PhoneNumber { get; set; }
        [Property(prefix: "\rcustomData=")] public string Motto { get; set; }
        [Property(prefix: "\rhas_read_agreement=")] public int HasReadAgreement => 1;
        [Property(prefix: "\rsex=")] public string Sex { get; set; }
        [Property(prefix: "\rcountry=")] public string Country { get; set; }
        [Property(prefix: "\rhas_special_rights=")] public int HasSpecialRights { get; set; } = 0;
        [Property(prefix: "\rbadge_type=")] public string BadgeType { get; set; } = "";
    }
}
