using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Segment
    {
        [XmlElement("segmentID")]
        public int Id { get; set; }
        [XmlElement("segmentName")]
        public string Name { get; set; }
    }
}
