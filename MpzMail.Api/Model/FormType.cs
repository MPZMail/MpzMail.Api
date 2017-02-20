using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum FormType
    {
        [XmlEnum("2")]
        Hosted = 2,
        [XmlEnum("3")]
        Embedded = 3,
        [XmlEnum("4")]
        Popup = 4
    }
}
