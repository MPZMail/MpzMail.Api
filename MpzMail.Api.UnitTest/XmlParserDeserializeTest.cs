using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MpzMail.Api.Contract;
using MpzMail.Api.Model.Base;
using MpzMail.Api.Model;
using System.Linq;

namespace MpzMail.Api.UnitTest
{
    [TestClass]
    public class XmlParserDeserializeTest
    {
        [TestMethod]
        [DeploymentItem("BaseResult.xml")]
        public void DeserializeBaseResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("BaseResult.xml");
            var result = xmlParser.Deserialize<BaseResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
        }

        [TestMethod]
        [DeploymentItem("RetrieveCampaignResult.xml")]
        public void DeserializeRetrieveCampaignResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("RetrieveCampaignResult.xml");
            var result = xmlParser.Deserialize<CampaignRetrieveResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("success", result.Message);
            var campaign = result.Campaign;
            Assert.IsNotNull(campaign);
            Assert.AreEqual(1234, campaign.Id);
            Assert.AreEqual("Sample Campaign", campaign.Name);
            Assert.AreEqual(new DateTime(2014, 6, 1, 11, 0, 0), campaign.CreateDate);
            Assert.AreEqual("Test User", campaign.SentFrom);
            Assert.AreEqual("My Sample Campaign", campaign.Subject);
            Assert.AreEqual(new DateTime(2014, 6, 2, 12, 0, 0), campaign.StartDate);
            Assert.AreEqual(CampaignStatus.Complete, campaign.Status);
            Assert.AreEqual(1314, campaign.GroupId);
            Assert.AreEqual("my@emailaddress.com", campaign.EmailFrom);
            Assert.AreEqual(12, campaign.TotalRecipients);
            Assert.AreEqual(3, campaign.Opened);
            Assert.AreEqual(2, campaign.Clicks);
            Assert.AreEqual(1, campaign.Unsubscribers);
            Assert.AreEqual(2, campaign.Bounced);
            Assert.AreEqual(2131, campaign.NewsletterId);
            Assert.AreEqual("21asvasvasv7as*V&VSA*V&ASVcsacascasc31", campaign.Newsletter);
        }

        [TestMethod]
        [DeploymentItem("CampaignResult.xml")]
        public void DeserializeCampaignResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var resultXml = File.ReadAllText("CampaignResult.xml");
            var result = xmlParser.Deserialize<CampaignResult>(resultXml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreNotEqual(null, result.Campaigns);
            Assert.AreEqual(1, result.Count);
            var first = result.Campaigns.FirstOrDefault();
            Assert.AreEqual(1234, first.Id);
            Assert.AreEqual("Sample Campaign", first.Name);
            Assert.AreEqual(new DateTime(2014, 6, 1, 11, 0, 0), first.CreateDate);
            Assert.AreEqual("Test User", first.SentFrom);
            Assert.AreEqual("My Sample Campaign", first.Subject);
            Assert.AreEqual(new DateTime(2014, 6, 2, 12, 0, 0), first.StartDate);
            Assert.AreEqual(CampaignStatus.Complete, first.Status);
            Assert.AreEqual(1314, first.GroupId);
            Assert.AreEqual("my@emailaddress.com", first.EmailFrom);
            Assert.AreEqual(12, first.TotalRecipients);
            Assert.AreEqual(3, first.Opened);
            Assert.AreEqual(2, first.Clicks);
            Assert.AreEqual(1, first.Unsubscribers);
            Assert.AreEqual(2, first.Bounced);
        }

        [TestMethod]
        [DeploymentItem("ViewOpenedEmailsResult.xml")]
        public void DeserializeViewOpenedEmails()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewOpenedEmailsResult.xml");
            var result = xmlParser.Deserialize<CampaignSubscriberResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.Count);
            var first = result.Subscribers.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual("Test", first.FirstName);
            Assert.AreEqual("User", first.LastName);
            Assert.AreEqual("test@user.com", first.Email);
            Assert.AreEqual(1233, first.GroupId);
            Assert.AreEqual("Test Company", first.CompanyName);
            Assert.AreEqual(new DateTime(2014, 2, 3, 11, 23, 0), first.LastActionDate);
            Assert.AreEqual(124124124, first.BindId);
            Assert.AreEqual(string.Empty, first.CustomField);
        }

        [TestMethod]
        [DeploymentItem("ViewEmailLinksResult.xml")]
        public void DeserializeViewClickedEmailLinks()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewEmailLinksResult.xml");
            var result = xmlParser.Deserialize<LinkResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result.Links.Count);
            var first = result.Links.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(1234, first.SubscriberId);
            Assert.AreEqual("Test", first.FirstName);
            Assert.AreEqual("User", first.LastName);
            Assert.AreEqual("test@user.com", first.Email);
            Assert.AreEqual(1233, first.GroupId);
            Assert.AreEqual(new DateTime(2016, 1, 3, 11, 23, 0), first.ClickDate);
            Assert.AreEqual("http://samplewebsite.com", first.ClickUrl);
            Assert.AreEqual(TrackingType.All, first.TrackingType);
            Assert.AreEqual(124124124, first.BindId);
            Assert.AreEqual(string.Empty, first.CustomField);
        }

        [TestMethod]
        [DeploymentItem("ViewCampaignUnsubscribersResult.xml")]
        public void DeserializeViewCampaignUnsubscribers()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewCampaignUnsubscribersResult.xml");
            var result = xmlParser.Deserialize<UnsubscriberResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result.Subscribers.Count);
            var first = result.Subscribers.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(1234, first.SubscriberId);
            Assert.AreEqual("Test", first.FirstName);
            Assert.AreEqual("User", first.LastName);
            Assert.AreEqual("test@user.com", first.Email);
            Assert.AreEqual(1233, first.GroupId);
            Assert.AreEqual("Test Company", first.CompanyName);
            Assert.AreEqual(new DateTime(2014, 2, 3, 11, 23, 0), first.LastActionDate);
            Assert.AreEqual(124124124, first.BindId);
            Assert.AreEqual(string.Empty, first.CustomField);
        }

        [TestMethod]
        [DeploymentItem("ViewBouncedEmailsResult.xml")]
        public void DeserializeViewBouncedEmailsResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewBouncedEmailsResult.xml");
            var result = xmlParser.Deserialize<CampaignSubscriberResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.Count);
            var first = result.Subscribers.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(1234, first.SubscriberId);
            Assert.AreEqual("Test", first.FirstName);
            Assert.AreEqual("User", first.LastName);
            Assert.AreEqual("test@user.com", first.Email);
            Assert.AreEqual(1233, first.GroupId);
            Assert.AreEqual("Test Company", first.CompanyName);
            Assert.AreEqual(new DateTime(2014, 2, 3, 11, 23, 0), first.LastActionDate);
            Assert.AreEqual(124124124, first.BindId);
            Assert.AreEqual(string.Empty, first.CustomField);
            Assert.AreEqual(BounceType.Hard, first.BounceType);
        }

        [TestMethod]
        [DeploymentItem("AddCampaignResult.xml")]
        public void DeserializeAddSubscriberResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("AddCampaignResult.xml");
            var result = xmlParser.Deserialize<CampaignAddResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1213, result.CampaignId);
            Assert.AreEqual(4213, result.TotalSubscribers);
        }

        [TestMethod]
        [DeploymentItem("AddNewsletterResult.xml")]
        public void DeserializeAddNewsletterResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("AddNewsletterResult.xml");
            var result = xmlParser.Deserialize<NewsletterAddResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual(151444, result.NewsletterId);
            Assert.AreEqual("success", result.Message);
        }

        [TestMethod]
        [DeploymentItem("NewsletterUploadImagesResult.xml")]
        public void DeserializeNewsletterUploadingImagesResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("NewsletterUploadImagesResult.xml");
            var result = xmlParser.Deserialize<NewsletterUploadImageResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.UploadedFilesCount);
            Assert.AreEqual(1, result.Files.Count);
            var first = result.Files.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual("12412414.jpg", first.ShortName);
            Assert.AreEqual("http://mpzmail.com/users/1312124/12412414.jpg", first.FullPath);
        }

        [TestMethod]
        [DeploymentItem("ViewNewsletterResult.xml")]
        public void DeserializeGetNewsletterResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewNewsletterResult.xml");
            var result = xmlParser.Deserialize<NewsletterListResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result.Newsletters.Count);
            var first = result.Newsletters.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(123, first.Id);
            Assert.AreEqual("Sample Newsletter", first.Name);
            Assert.AreEqual(new DateTime(2014, 5, 2, 12, 23, 0), first.CreateDate);
            Assert.AreEqual(new DateTime(2014, 6, 3, 11, 20, 0), first.UpdateDate);
            Assert.AreEqual("<strong>Welcome to our Newsletter</strong> Here is our newsletter", first.Html);
        }

        [TestMethod]
        [DeploymentItem("AddSubscribersResult.xml")]
        public void DeserializeAddSubscribersResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("AddSubscribersResult.xml");
            var result = xmlParser.Deserialize<SubscriberAddResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(2, result.Subscribers.Count);
            var first = result.Subscribers.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(Status.Successful, first.Status);
            Assert.AreEqual("success", first.Message);
            Assert.AreEqual(12314, first.Id);
            Assert.AreEqual("test@test.com", first.Email);
            var second = result.Subscribers.ElementAt(1);
            Assert.IsNotNull(second);
            Assert.AreEqual(Status.Successful, second.Status);
            Assert.AreEqual("success", second.Message);
            Assert.AreEqual(12315, second.Id);
            Assert.AreEqual("test2@test2.com", second.Email);
        }

        [TestMethod]
        [DeploymentItem("ListSubscribersResult.xml")]
        public void DeserializeListSubscribersResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ListSubscribersResult.xml");
            var result = xmlParser.Deserialize<SubscriberListResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(2, result.Subscribers.Count);
            Assert.AreEqual(2, result.Count);
            var first = result.Subscribers.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(1311, first.Id);
            Assert.AreEqual("Test", first.FirstName);
            Assert.AreEqual("User", first.LastName);
            Assert.AreEqual("Test Co", first.CompanyName);
            Assert.AreEqual("test@test.com", first.Email);
            Assert.AreEqual(new DateTime(2014, 1, 1, 11, 37, 0), first.CreateDate);
            Assert.AreEqual(null, first.CustomField1);
            Assert.AreEqual(null, first.CustomField2);
            Assert.AreEqual(null, first.CustomField3);
            Assert.AreEqual(null, first.CustomField5);
            Assert.AreEqual(null, first.CustomField6);
            Assert.AreEqual(null, first.CustomField7);
            Assert.AreEqual(null, first.CustomField8);
            Assert.AreEqual(null, first.CustomField9);
            Assert.AreEqual(null, first.CustomField10);

            var second = result.Subscribers.ElementAt(1);
            Assert.IsNotNull(second);
            Assert.AreEqual(1312, second.Id);
            Assert.AreEqual("Test2", second.FirstName);
            Assert.AreEqual("User2", second.LastName);
            Assert.AreEqual("Test Co2", second.CompanyName);
            Assert.AreEqual("test@test2.com", second.Email);
            Assert.AreEqual(new DateTime(2014, 3, 5, 12, 25, 0), second.CreateDate);
            Assert.AreEqual(null, second.CustomField1);
            Assert.AreEqual(null, second.CustomField2);
            Assert.AreEqual(null, second.CustomField3);
            Assert.AreEqual(null, second.CustomField5);
            Assert.AreEqual(null, second.CustomField6);
            Assert.AreEqual(null, second.CustomField7);
            Assert.AreEqual(null, second.CustomField8);
            Assert.AreEqual(null, second.CustomField9);
            Assert.AreEqual(null, second.CustomField10);
        }

        [TestMethod]
        [DeploymentItem("BulkAddSubscribersResult.xml")]
        public void DeserializeBulkAddSubscribersResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("BulkAddSubscribersResult.xml");
            var result = xmlParser.Deserialize<SubscriberBulkAddResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            Assert.AreEqual(124124, result.ImportId);
        }

        [TestMethod]
        [DeploymentItem("QueryBulkResult.xml")]
        public void DeserializeQueryBulkResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("QueryBulkResult.xml");
            var result = xmlParser.Deserialize<SubscriberInternalBulkImportResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("success", result.Message);
            var job = result.Job;
            Assert.IsNotNull(job);
            Assert.AreEqual(JobStatus.Finished, job.Status);
            Assert.AreEqual(2, job.DetectedSubscribersCount);
            Assert.AreEqual(2, job.ProcessedSubscribersCount);
            Assert.AreEqual(1, job.InvalidEmailAddressesCount);
            Assert.AreEqual(0, job.DuplicateEmailAddressesCount);
            Assert.AreEqual(1, job.PreviouslyUnsubscribedEmailAddressesCount);
            Assert.AreEqual(string.Empty, job.InvalidEmailAddresses);
            Assert.AreEqual("test@test.com", job.DuplicateEmailAddresses);
            Assert.AreEqual("unsubscriber@test.com", job.PreviouslyUnsubscribedEmailAddresses);
        }

        [TestMethod]
        [DeploymentItem("ViewSignUpFormsResult.xml")]
        public void DeserializeViewSignUpFormsResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewSignUpFormsResult.xml");
            var result = xmlParser.Deserialize<FormResult>(xml);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result.Forms.Count);
            var first = result.Forms.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(3403, first.Id);
            Assert.AreEqual(412, first.GroupId);
            Assert.AreEqual(new DateTime(2016, 6, 19, 16, 33, 0), first.CreateDate);
            Assert.AreEqual("Facebook Form", first.Title);
            Assert.AreEqual(null, first.Html); // serialized to null??
            Assert.AreEqual(234, first.ViewCount);
            Assert.AreEqual(8, first.RegisterCount);
            Assert.AreEqual(FormType.Hosted, first.Type);
        }

        [TestMethod]
        [DeploymentItem("AddGroupResult.xml")]
        public void DeserializeAddGroupResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("AddGroupResult.xml");
            var result = xmlParser.Deserialize<GroupAddResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("Success", result.Message);
            Assert.AreEqual("1234", result.GroupId);
        }

        [TestMethod]
        [DeploymentItem("ViewGroupsResult.xml")]
        public void DeserializeViewGroupsResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewGroupsResult.xml");
            var result = xmlParser.Deserialize<GroupListResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("Success", result.Message);
            Assert.AreEqual(2, result.GroupCount);
            Assert.AreEqual(2, result.Groups.Count);
            var first = result.Groups.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual("Test Group 1", first.Name);
            Assert.AreEqual("123", first.Id);
            Assert.AreEqual(1321, first.SubscriberCount);
            Assert.AreEqual(new DateTime(2014, 3, 1, 11, 0, 0), first.CreateDate);
            var second = result.Groups.ElementAt(1);
            Assert.IsNotNull(second);
            Assert.AreEqual("Test Group 2", second.Name);
            Assert.AreEqual("124", second.Id);
            Assert.AreEqual(113, second.SubscriberCount);
            Assert.AreEqual(new DateTime(2014, 5, 3, 12, 1, 0), second.CreateDate);
        }

        [TestMethod]
        [DeploymentItem("DeleteGroupResult.xml")]
        public void DeserializeDeleteGroupResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("DeleteGroupResult.xml");
            var result = xmlParser.Deserialize<GroupDeleteGroupResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("Success", result.Message);
            Assert.AreEqual("1234", result.GroupId);
        }

        [TestMethod]
        [DeploymentItem("ViewSegmentsResult.xml")]
        public void DeserializeViewSegmentsResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var xml = File.ReadAllText("ViewSegmentsResult.xml");
            var result = xmlParser.Deserialize<SegmentListResult>(xml);
            Assert.AreEqual(Status.Successful, result.Status);
            Assert.AreEqual("Success", result.Message);
            Assert.AreEqual(2, result.SegmentCount);
            Assert.AreEqual(2, result.Segments.Count);
            var first = result.Segments.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual(122, first.Id);
            Assert.AreEqual("Test Segment 1", first.Name);
            var second = result.Segments.ElementAt(1);
            Assert.IsNotNull(second);
            Assert.AreEqual(123, second.Id);
            Assert.AreEqual("Test Segment 2", second.Name);
        }

        [TestMethod]
        [DeploymentItem("AddSegmentResult.xml")]
        public void DeserializeAddSegmentResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            //var xml = File.ReadAllText("AddSegmentResult.xml");
            //var result = xmlParser.Deserialize<Segmentre>
        }
    }
}
