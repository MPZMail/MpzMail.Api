using MpzMail.Api.Model.Base;
using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class RetrieveCampaignRequest : BaseRequest
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
    }
}
