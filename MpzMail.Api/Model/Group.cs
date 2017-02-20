using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Group
    {
        [XmlElement("groupName")]
        public string Name { get; set; }
        [XmlElement("groupID")]
        public string Id { get; set; }
        [XmlElement("subscribers")]
        public int SubscriberCount { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDate { get; set; }
    }
}
