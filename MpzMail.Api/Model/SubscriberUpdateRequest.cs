using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberUpdateRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        public bool ShouldSerializeFirstName()
        {
            return !string.IsNullOrEmpty(FirstName);
        }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        public bool ShouldSerializeLastName()
        {
            return !string.IsNullOrEmpty(LastName);
        }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        public bool ShouldSerializeCompanyName()
        {
            return !string.IsNullOrEmpty(CompanyName);
        }
    }
}
