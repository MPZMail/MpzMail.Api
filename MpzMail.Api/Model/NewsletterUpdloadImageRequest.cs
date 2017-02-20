using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterUpdloadImageRequest : BaseRequest
    {
        [XmlArray("files")]
        [XmlArrayItem("file")]
        public List<FileRequest> Files { get; set; }
    }
}
