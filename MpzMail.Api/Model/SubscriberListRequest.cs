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
        public int? SubscriberCountToReturn { get; set; }
        public bool ShouldSerializeSubscriberCountToReturn()
        {
            return SubscriberCountToReturn.HasValue;
        }
        [XmlElement("sortField")]
        public SubscriberSortField? FieldToSortBy { get; set; }
        public bool ShouldSerializeFieldToSortBy()
        {
            return FieldToSortBy.HasValue;
        }
        [XmlElement("sortOrder")]
        public SubscriberSortOrder? DirectionToSortBy { get; set; }
        public bool ShouldSerializeDirectionToSortBy()
        {
            return DirectionToSortBy.HasValue;
        }
        [XmlElement("emailAddress")]
        public string PartOfOrWholeEmail { get; set; }
        public bool ShouldSerializePartOfOrWholeEmail()
        {
            return !string.IsNullOrEmpty(PartOfOrWholeEmail);
        }
    }
}
