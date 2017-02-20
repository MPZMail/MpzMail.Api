using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [Serializable]
    public enum Status
    {
        [XmlEnum("0")]
        Successful = 0,
        [XmlEnum("1")]
        Error = 1
    }
}
