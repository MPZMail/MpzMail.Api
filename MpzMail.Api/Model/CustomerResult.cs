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
    public class CustomerResult : BaseResult
    {
        [XmlElement("userCnt")]
        public int Count { get; set; }
        [XmlArray("users")]
        [XmlArrayItem("user")]
        public List<Customer> Customers { get; set; }
    }
}
