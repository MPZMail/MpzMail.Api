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
    public class AccountResult : BaseResult
    {
        [XmlElement("userID")]
        public string UserId { get; set; }

        [XmlElement("apiKey")]
        public string NewApiKey { get; set; }
    }
}
