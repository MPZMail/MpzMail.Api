using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum SubscriberSortOrder
    {
        [XmlEnum("asc")]
        Asc = 0,
        [XmlEnum("desc")]
        Desc = 1
    }
}
