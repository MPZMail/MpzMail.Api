using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum AccountType
    {
        [XmlEnum("0")]
        Normal,
        [XmlEnum("1")]
        FreeForever = 1
    }
}
