using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum DateSegmentFieldType
    {
        [XmlElement("dateOfBirth")]
        DateOfBirth = 0,
        [XmlElement("dateAdded")]
        CreateDate = 1
    }
}
