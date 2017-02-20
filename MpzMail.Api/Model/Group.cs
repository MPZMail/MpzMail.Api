using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Group
    {
        [XmlIgnore]
        public DateTime CreateDate { get; set; }
        [XmlElement("groupName")]
        public string Name { get; set; }
        [XmlElement("groupID")]
        public string Id { get; set; }
        [XmlElement("subscribers")]
        public int SubscriberCount { get; set; }
        [XmlElement("dateCreated")]
        public string CreateDateString {
            get { return this.CreateDate.ToString("yyyy-MM-dd HH:mm"); }
            set { this.CreateDate = DateTime.Parse(value); }
        }
    }
}
