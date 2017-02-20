using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class DateSegmentField : ISegmentField
    {
        [XmlElement("field")]
        public DateSegmentFieldType FieldType { get; set; }
        [XmlElement("modifier")]
        public DateModifier Modifier { get; set; }
        public string Value { get; set; }
    }
}
