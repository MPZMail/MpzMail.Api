using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SubscriberInternalBulkImportResult : BaseResult
    {
        [XmlElement("job")]
        public InternalJob Job { get; set; }
    }
}
