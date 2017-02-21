using MpzMail.Api.Model;
using MpzMail.Api.Model.Base;
using System.Collections.Generic;

namespace MpzMail.Api.Contract
{
    public interface IMpzWrapper
    {
        #region Campaigns
        CampaignAddResult AddCampaign(CampaignAddRequest campaignToAdd);
        CampaignResult GetCampaigns();
        CampaignResult GetCampaigns(DateFilter filter);
        CampaignRetrieveResult GetCampaign(int campaignId);
        CampaignSubscriberResult GetOpenedEmails(int campaignId);
        CampaignSubscriberResult GetOpenedEmails(int campaignId, DateFilter filter);
        LinkResult GetClickedLinks(int campaignId);
        LinkResult GetClickedLinks(int campaignId, LinkFilter filter);
        UnsubscriberResult GetUnsubscribers(int campaignId);
        UnsubscriberResult GetUnsubscribers(int campaignId, DateFilter filter);
        CampaignSubscriberResult GetBounces(int campaignId);
        CampaignSubscriberResult GetBounces(int campaignId, DateFilter filter);
        #endregion

        #region Newsletters
        NewsletterAddResult AddNewsletter(string newsletterName, string htmlBody);
        NewsletterUploadImageResult UploadNewsletterImages(List<FileRequest> files);
        NewsletterListResult GetNewsletters();
        #endregion

        #region Forms
        FormResult GetForms();
        #endregion

        #region Subscribers
        SubscriberAddResult AddSubscribers(int groupId, bool? returnCustomFields, List<Subscriber> subscribers);
        SubscriberListResult GetSubscribers(int groupId, SubscriberFilter filter);
        UnsubscriberListResult ListUnsubscribers(int groupId, DateFilter filter);
        BaseResult UpdateSubscriber(int groupId, int subscriberId, string firstName, string lastName, string companyName);
        BaseResult UnsubscribeSubscriberFromAllGroups(string emailAddress);
        BaseResult UnsubscribeSubscriberFromAllGroups(int id);
        BaseResult UnsubscribeSubscriberFromSpecificGroup(string emailAddress, int groupId, ReturnAllFields returnWithCustomFields);
        BaseResult UnsubscribeSubscriberFromSpecificGroup(int Id, int groupId, ReturnAllFields returnWithCustomFields);
        SubscriberBulkAddResult BulkAddSubscribers(int groupId, List<Subscriber> subscribers);
        SubscriberBulkImportResult QueryBulkImport(int importId);
        #endregion

        #region Gropus
        GroupAddResult AddGroup(string groupName);
        GroupListResult GetGroups();
        GroupDeleteGroupResult DeleteGroup(string groupId);
        SegmentListResult GetSegments(string groupId);
        #endregion

        #region Customers
        CustomerResult GetCustomers();
        #endregion
    }
}
