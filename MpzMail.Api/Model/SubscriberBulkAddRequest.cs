using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberBulkAddRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("fileData")]
        public string CsvSubscribersBase65Encoded { get; set; }
    }
}
