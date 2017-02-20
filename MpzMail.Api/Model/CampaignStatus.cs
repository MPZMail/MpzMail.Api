using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum CampaignStatus
    {
        [XmlEnum("0")]
        Scheduled = 0,
        [XmlEnum("1")]
        Queued = 1,
        [XmlEnum("2")]
        CopyingSubscribers = 2,
        [XmlEnum("3")]
        SendingCampaign = 3,
        [XmlEnum("4")]
        Complete = 4
    }
}
