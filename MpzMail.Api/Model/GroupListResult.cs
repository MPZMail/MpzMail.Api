using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class GroupListResult : BaseResult
    {
        [XmlElement("groupCnt")]
        public int GroupCount { get; set; }
        [XmlArray("groups")]
        [XmlArrayItem("group")]
        public List<Group> Groups { get; set; }
    }
}
