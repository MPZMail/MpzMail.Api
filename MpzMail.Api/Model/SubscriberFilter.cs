namespace MpzMail.Api.Model
{
    public class SubscriberFilter
    {
        public int? NumberOfSubscribersToReturn { get; set; }
        public SubscriberSortField? SortBy { get; set; }
        public SubscriberSortOrder? SortOrder { get; set; }
        public string PartOfOrWholeEmail { get; set; }
    }
}
