using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Group
    {
        [XmlElement("dateCreated")]
        public DateTime CreateDate { get; set; }
        [XmlElement("groupName")]
        public string Name { get; set; }
        [XmlElement("groupID")]
        public string Id { get; set; }
        [XmlElement("subscribers")]
        public int SubscriberCount { get; set; }
    }
}
