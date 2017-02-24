using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class CampaignRequestWithEndDate : BaseRequest
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("endDate")]
        public DateTime EndDate { get; set; }
    }
}
