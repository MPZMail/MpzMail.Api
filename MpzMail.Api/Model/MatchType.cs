using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum MatchType
    {
        [XmlEnum("0")]
        Any = 0,
        [XmlEnum("1")]
        All = 1
    }
}
