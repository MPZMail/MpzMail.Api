using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SubscriberAddRequestModel
    {
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("customField1")]
        public string FirstCustomField { get; set; }
        [XmlElement("customField2")]
        public string SecondCustomField { get; set; }
        [XmlElement("customField3")]
        public string ThirdCustomField { get; set; }
        [XmlElement("customField4")]
        public string FourthCustomField { get; set; }
        [XmlElement("customField5")]
        public string FifthCustomField { get; set; }
        [XmlElement("customField6")]
        public string SixthCustomField { get; set; }
        [XmlElement("customField7")]
        public string SeventhCustomField { get; set; }
        [XmlElement("customField8")]
        public string EighthCustomField { get; set; }
        [XmlElement("customField9")]
        public string NinthCustomField { get; set; }
        [XmlElement("customField10")]
        public string TenthCustomField { get; set; }
        [XmlElement("houseNo")]
        public string HouseNumber { get; set; }
        [XmlElement("address1")]
        public string FirstAddress { get; set; }
        [XmlElement("address2")]
        public string SecondAddress { get; set; }
        [XmlElement("town")]
        public string City { get; set; }
        [XmlElement("county")]
        public string State { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }
        [XmlElement("postcode")]
        public string PostalCode { get; set; }
        [XmlElement("isActive")]
        public ActiveState Active { get; set; }
    }
}
