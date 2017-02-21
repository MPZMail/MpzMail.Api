using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class SubscriberListResultModel
    {
        [XmlElement("dateAdded")]
        public DateTime CreateDate { get; set; }
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

        #region CustomFields
        [XmlElement("customField1")]
        public string CustomField1 { get; set; }
        [XmlElement("customField2")]
        public string CustomField2 { get; set; }
        [XmlElement("customField3")]
        public string CustomField3 { get; set; }
        [XmlElement("customField4")]
        public string CustomField4 { get; set; }
        [XmlElement("customField5")]
        public string CustomField5 { get; set; }
        [XmlElement("customField6")]
        public string CustomField6 { get; set; }
        [XmlElement("customField7")]
        public string CustomField7 { get; set; }
        [XmlElement("customField8")]
        public string CustomField8 { get; set; }
        [XmlElement("customField9")]
        public string CustomField9 { get; set; }
        [XmlElement("customField10")]
        public string CustomField10 { get; set; }
        #endregion
    }
}
