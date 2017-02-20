using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public class Customer
    {
        [XmlElement("fullName")]
        public string FullName { get; set; }
        [XmlElement("emailAddress")]
        public string EmailAddress { get; set; }
        [XmlElement("apiKey")]
        public string ApiKey;
    }
}
