using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Subscriber
    {
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("firstName")]
        public string FirstName { get; set; }
        [XmlElement("lastName")]
        public string LastName { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("houseNo")]
        public string HouseNumber { get; set; }
        [XmlElement("address1")]
        public string FirstAddress { get; set; }
        [XmlElement("address2")]
        public string SecondAddress { get; set; }
        [XmlElement("town")]
        public string City { get; set; }
        [XmlElement("county")]
        public string County { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }
        [XmlElement("postcode")]
        public string PostalCode { get; set; }
        [XmlElement("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [XmlElement("isActive")]
        public ActiveState Active { get; set; }

        #region Customfields
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

        public override string ToString()
        {
            return $"{this.Email},{this.FirstName},{this.LastName},{this.CompanyName},{this.HouseNumber},{this.FirstAddress},{this.SecondAddress},{this.City},{this.County},{this.County},{this.PostalCode},{this.DateOfBirth.ToString()},{this.CustomField1},{this.CustomField2},{this.CustomField3},{this.CustomField4},{this.CustomField5},{this.CustomField6}{this.CustomField7},{this.CustomField8},{this.CustomField9},{this.CustomField10}";
        }
    }
}
