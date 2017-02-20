using MpzMail.Api.Model.Base;

namespace MpzMail.Api.Model
{
    public class SubscriberBulkImportResult : BaseResult
    {
        public Job Job { get; set; }
    }
}
