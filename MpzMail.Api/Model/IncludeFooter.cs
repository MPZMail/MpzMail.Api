using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [Serializable]
    public enum IncludeFooter
    {
        [XmlEnum("0")]
        No = 0,
        [XmlEnum("1")]
        Yes = 1
    }
}
