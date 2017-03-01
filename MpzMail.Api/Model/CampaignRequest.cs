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
    public class CampaignRequest : BaseRequest
    {
        [XmlElement("campaignID")]
        public int CampaignId { get; set; }
        [XmlElement("fromDate")]
        public DateTime? FromDate { get; set; }
        public bool ShouldSerializeFromDate()
        {
            return FromDate.HasValue;
        }
        [XmlElement("toDate")]
        public DateTime? ToDate { get; set; }
        public bool ShouldSerializeToDate()
        {
            return ToDate.HasValue;
        }
    }
}
