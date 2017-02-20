using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SegmentListRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public string GroupId { get; set; }
    }
}
