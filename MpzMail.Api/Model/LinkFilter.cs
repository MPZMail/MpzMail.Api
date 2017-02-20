using System;

namespace MpzMail.Api.Model
{
    public class LinkFilter
    {
        public TrackingType? Type { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
