using System.Collections.Generic;

namespace MpzMail.Api.Model
{
    public class Job
    {
        public JobStatus Status { get; set; }
        public int DetectedSubscribersCount { get; set; }
        public int ProcessedSubscribersCount { get; set; }
        public int DuplicateEmailAddressesCount { get; set; }
        public int PreviouslyUnsubscribedEmailAddressesCount { get; set; }
        public int InvalidEmailAddresssesCount { get; set; }
        public List<string> DuplicateEmailAddresses { get; set; }
        public List<string> InvalidEmailAddresses { get; set; }
        public List<string> PreviouslyUnsubscribedEmailAddresses { get; set; }
    }
}
