using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SubscriberListResultModel
    {
        [XmlElement("subscriberID")]
        public int Id { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("dateAdded")]
        public string CreateDate { get; set; }
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
    }
}
