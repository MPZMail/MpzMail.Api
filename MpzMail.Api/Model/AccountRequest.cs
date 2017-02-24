using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class AccountRequest : BaseRequest
    {
        [XmlElement("emailaddress")]
        public string EmailAddress { get; set; }
        [XmlElement("password")]
        public string Password { get; set; }
        [XmlElement("fullname")]
        public string Fullname { get; set; }
        [XmlElement("agencyAccount")]
        public AgencyAccount AgencyAccount { get; set; }
        [XmlElement("agencyID")]
        public string AgencyId { get; set; }
        [XmlElement("isFreeAccount")]
        public AccountType Type { get; set; }
    }
}
