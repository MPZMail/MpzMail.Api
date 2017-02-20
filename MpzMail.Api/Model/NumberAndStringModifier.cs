using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum NumberAndStringModifier
    {
        [XmlElement("Equals")]
        Equals = 0,
        [XmlElement("Doesnt Equal")]
        DoesNotEqual = 1,
        [XmlElement("Contains")]
        Contains = 2,
        [XmlElement("Does Not Contain")]
        DoesNotContain = 3,
        [XmlElement("Is Provided")]
        IsProvided = 4,
        [XmlElement("Is Not Provided")]
        IsNotProvided = 5
    }
}
