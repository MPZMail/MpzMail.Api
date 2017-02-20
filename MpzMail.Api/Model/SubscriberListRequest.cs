using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberListRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("noOfSubscribers")]
        public int SubscriberCountToReturn { get; set; }
        [XmlElement("sortField")]
        public SubscriberSortField FieldToSortBy { get; set; }
        [XmlElement("sortOrder")]
        public SubscriberSortOrder DirectionToSortBy { get; set; }
        [XmlElement("emailAddress")]
        public string PartOfOrWholeEmail { get; set; }
    }
}
