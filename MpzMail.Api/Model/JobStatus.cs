using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    public enum JobStatus
    {
        [XmlEnum("0")]
        Queued = 0,
        [XmlEnum("1")]
        InProgress = 1,
        [XmlEnum("2")]
        Finished = 2,
        [XmlEnum("3")]
        FinishedAndSeenFromUser = 3
    }
}
