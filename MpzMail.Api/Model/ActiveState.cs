using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum ActiveState
    {
        [XmlEnum("0")]
        Active = 0,
        [XmlEnum("1")]
        Inactive = 1
    }
}
