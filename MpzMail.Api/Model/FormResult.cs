using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class FormResult : BaseResult
    {
        [XmlElement("formCnt")]
        public int Count { get; set; }
        [XmlArray("forms")]
        [XmlArrayItem("form")]
        public List<Form> Forms { get; set; }
    }
}
