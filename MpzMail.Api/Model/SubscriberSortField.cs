using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum SubscriberSortField
    {
        [XmlEnum("subscriberId")]
        Id = 0,
        [XmlEnum("firstName")]
        FirstName = 1,
        [XmlEnum("lastName")]
        LastName = 2,
        [XmlEnum("companyName")]
        CompanyName = 3
    }
}
