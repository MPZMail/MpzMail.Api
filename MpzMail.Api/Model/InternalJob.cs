using System.Xml.Serialization;

namespace MpzMail.Api.Model
{

    public class InternalJob
    {
        [XmlElement("jobStatus")]
        public JobStatus Status { get; set; }
        [XmlElement("totSubs")]
        public int DetectedSubscribersCount { get; set; }
        [XmlElement("totDone")]
        public int ProcessedSubscribersCount { get; set; }
        [XmlElement("totInvalid")]
        public int InvalidEmailAddressesCount { get; set; }
        [XmlElement("totDupes")]
        public int DuplicateEmailAddressesCount { get; set; }
        [XmlElement("totUnsubscribed")]
        public int PreviouslyUnsubscribedEmailAddressesCount { get; set; }
        [XmlElement("dupeData")]
        public string DuplicateEmailAddresses { get; set; }
        [XmlElement("invalidData")]
        public string InvalidEmailAddresses { get; set; }
        [XmlElement("unsubData")]
        public string PreviouslyUnsubscribedEmailAddresses { get; set; }
    }
}
