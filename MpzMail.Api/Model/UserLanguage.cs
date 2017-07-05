using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum UserLanguage
    {
        [XmlEnum("en")]
        En,
        [XmlEnum("fi")]
        Fi,
        [XmlEnum("fr")]
        Fr,
        [XmlEnum("de")]
        De,
        [XmlEnum("it")]
        It,
        [XmlEnum("pt")]
        Pt,
        [XmlEnum("ru")]
        Ru
    }
}
