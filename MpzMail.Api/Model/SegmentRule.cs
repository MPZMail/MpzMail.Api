using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SegmentRule
    {
        [XmlElement("field")]
        public ISegmentField Field { get; set; }
    }
}
