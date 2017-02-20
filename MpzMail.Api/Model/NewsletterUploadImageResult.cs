using MpzMail.Api.Model.Base;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterUploadImageResult : BaseResult
    {
        [XmlElement("totalFilesUploaded")]
        public int UploadedFilesCount { get; set; }
        [XmlArray("filesUploaded")]
        [XmlArrayItem("file")]
        public List<FileResult> Files { get; set; }
    }
}
