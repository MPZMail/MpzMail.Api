using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum AgencyAccount
    {
        [XmlEnum("0")]
        Standard = 0,
        [XmlEnum("1")]
        AgencyAccount = 1
    }
}
