using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class UnsubscriberListRequest : BaseRequest
    {
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("startDate")]
        public DateTime? StartDateString { get; set; }
        public DateTime? EndDateString { get; set; }
    }
}
