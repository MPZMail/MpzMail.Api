using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class GroupAddRequest : BaseRequest
    {
        [XmlElement("groupName")]
        public string GroupName { get; set; }
    }
}
