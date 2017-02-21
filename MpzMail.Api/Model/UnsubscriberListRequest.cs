using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class UnsubscriberListRequest : BaseRequest
    {
        [XmlElement("startDate")]
        public DateTime StartDate { get; set; }
        [XmlElement("endDate")]
        public DateTime EndDate { get; set; }
        [XmlElement("groupID")]
        public int GroupId { get; set; }
    }
}
