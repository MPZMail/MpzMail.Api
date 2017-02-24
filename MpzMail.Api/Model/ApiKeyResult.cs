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
    public class ApiKeyResult : BaseResult
    {
        [XmlElement("apiKey")]
        public string ApiKey { get; set; }
    }
}
