using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberBulkQueryRequest : BaseRequest
    {
        [XmlElement("importID")]
        public int ImportId { get; set; }
    }
}
