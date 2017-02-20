using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum NumberTextSegmentFieldType
    {
        [XmlEnum("firstName")]
        FirstName = 0,
        [XmlElement("lastName")]
        LastName = 1,
        [XmlElement("email")]
        Email = 2,
        [XmlElement("houseNo")]
        HouseNo = 3,
        [XmlElement("address1")]
        Address1 = 4,
        [XmlElement("address2")]
        Address2 = 5,
        [XmlElement("town")]
        City = 6,
        [XmlElement("county")]
        State = 7,
        [XmlElement("postCode")]
        PostalCode = 8,
        [XmlElement("gender")]
        Gender = 9,
        [XmlElement("job")]
        Job = 10,
        [XmlElement("customField1")]
        CustomField1 = 11,
        [XmlElement("customField2")]
        CustomField2 = 12,
        [XmlElement("customField3")]
        CustomField3 = 13,
        [XmlElement("customField4")]
        CustomField4 = 14,
        [XmlElement("customField5")]
        CustomField5 = 15,
        [XmlElement("customField6")]
        CustomField6 = 16,
        [XmlElement("customField7")]
        CustomField7 = 17,
        [XmlElement("customField8")]
        CustomField8 = 18,
        [XmlElement("customField9")]
        CustomField9 = 19,
        [XmlElement("customField10")]
        CustomField10 = 20,
    }
}
