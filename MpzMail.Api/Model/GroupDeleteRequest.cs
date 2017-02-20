using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class GroupDeleteRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public string GroupId { get; set; }
    }
}
