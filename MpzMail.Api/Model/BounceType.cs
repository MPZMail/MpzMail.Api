using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [Serializable]
    public enum BounceType
    {
        [XmlEnum("none")]
        None = 0,
        [XmlEnum("hard")]
        Hard = 1,
        [XmlEnum("soft")]
        Soft = 2
    }
}
