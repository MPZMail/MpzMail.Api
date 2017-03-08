using Microsoft.VisualStudio.TestTools.UnitTesting;
using MpzMail.Api.Contract;
using MpzMail.Api.Model;
using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpzMail.Api.UnitTest
{
    [TestClass]
    public class XmlParserSerializeTest
    {
        [TestMethod]
        [DeploymentItem("BaseRequest.xml")]
        public void SerializeBaseRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new BaseRequest
            {
                ApiKey = "44-121312131223"
            };

            var requestXml = xmlParser.Serialize(request);

            var xml = File.ReadAllText("BaseRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("GroupRequestName.xml")]
        public void SerializeGroupAddRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new GroupAddRequest
            {
                ApiKey = "44-121312131223",
                GroupName = "My New Group"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("GroupRequestName.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("GroupRequestId.xml")]
        public void SerializeGroupDeleteRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new GroupDeleteRequest
            {
                ApiKey = "44-121312131223",
                GroupId = "12412414"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("GroupRequestId.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("SegmentListRequest.xml")]
        public void SerializeSegmentListRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SegmentListRequest
            {
                ApiKey = "44-121312131223",
                GroupId = "12331"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("SegmentListRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("SegmentAddRequest.xml")]
        public void SerializeSegmentAddRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SegmentAddRequest
            {
                ApiKey = "44-121312131223",
                GroupId = 42131,
                MatchType = MatchType.All,
                Name = "My New Segment",
                Rules = new List<SegmentRule>
                {
                    new SegmentRule
                    {
                        Field = SegmentField.FirstName,
                        Modifier = SegmentModifier.Contains,
                        Value = "hotmail.com"
                    },
                    new SegmentRule
                    {
                        Field = SegmentField.DateAdded,
                        Modifier = SegmentModifier.IsAfter,
                        Value = "2014-04-21"
                    }
                }
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("SegmentAddRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("ViewSegmentsRequest.xml")]
        public void SerializeViewSegmentsRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SegmentListRequest
            {
                ApiKey = "44-121312131223",
                GroupId = "123"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("ViewSegmentsRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("ViewUnsubscribersRequest.xml")]
        public void ListUnsubscribersRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new UnsubscriberListRequest
            {
                ApiKey = "44-121312131223",
                GroupId = 3213,
                StartDate = new DateTime(2014, 1, 1),
                EndDate = new DateTime(2015, 1, 1)
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("ViewUnsubscribersRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("UpdateSubscriberRequest.xml")]
        public void SerializeUpdateSubscriberRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SubscriberUpdateRequest
            {
                ApiKey = "44-121312131223",
                GroupId = 213213,
                SubscriberId = 981413,
                FirstName = "Test",
                LastName = "User",
                CompanyName = "Test Company"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("UpdateSubscriberRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("UnsubscribeSubscriberRequestWithEmail.xml")]
        public void SerializeUnsubscribeSubscriberRequestWithEmail()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new UnsubscribeSubscriberRequestWithEmail
            {
                ApiKey = "44-121312131223",
                Email = "test@test.com"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("UnsubscribeSubscriberRequestWithEmail.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("UnsubscribeSubscriberRequestWithId.xml")]
        public void SerializeUnsubscribeSubscriberRequestWithId()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new UnsubscribeSubscriberRequestWithId
            {
                ApiKey = "44-121312131223",
                SubscriberId = 12323
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("UnsubscribeSubscriberRequestWithId.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("CreateAccountRequest.xml")]
        public void SerializeCreateAccountRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new AccountRequest
            {
                ApiKey = "553-1123-32131231",
                EmailAddress = "your@username.com",
                Password = "password",
                Fullname = "John Smith"
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("CreateAccountRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("TransferCreditsRequest.xml")]
        public void SerializeTransferCreditsRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new TransferCreditRequest
            {
                ApiKey = "553-1123-32131231",
                RecipientId = 123123123,
                Credits = 1000
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("TransferCreditsRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("BulkAddSubscribersRequest.xml")]
        public void SerializeBulkAddSubscribersRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SubscriberBulkAddRequest
            {
                ApiKey = "44-121312131223",
                GroupId = 213213,
                CsvSubscribersBase65Encoded = "ZW1haWwsZmlyc3RuYW1lLGxhc3ROYW1lLGNvbXBhbnlOYW1lLGhvdXNlTm8sYWRkcmVzczEsYWRkcmVzczIsdG93bixjb 3VudHksY291bnRyeSxwb3N0Q29kZSxkYXRlT2ZCaXJ0aCxnZW5kZXIsY3VzdG9tRmllbGQxLGN1c3RvbUZpZWxkMixjdX N0b21GaWVsZDMsY3VzdG9tRmllbGQ0LGN1c3RvbUZpZWxkNSxjdXN0b21GaWVsZDYsY3VzdG9tRmllbGQ3LGN1c3RvbUZ pZWxkOCxjdXN0b21GaWVsZDksY3VzdG9tRmllbGQxMA=="
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("BulkAddSubscribersRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("QueryBulkImportRequest.xml")]
        public void SerializeQueryBulkImportRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new SubscriberBulkQueryRequest
            {
                ApiKey = "44-121312131223",
                ImportId = 213213
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("QueryBulkImportRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("AddNewsletterRequest.xml")]
        public void SerializeAddNewsletterRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            
            var request = new NewsletterAddRequest
            {
                ApiKey = "44-121312131223",
                NewsletterName = "Test Newsletters",
                Html = "<strong>Welcome to our new newsletter</strong><br/><br/>We hope you enjoy it!"
            };


            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("AddNewsletterRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("UploadNewsletterImagesRequest.xml")]
        public void SerializeUploadNewsletterImagesRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();

            var request = new NewsletterUpdloadImageRequest
            {
                ApiKey = "441233-121312131223",
                Files = new List<FileRequest>
                {
                    new FileRequest
                    {
                        Extension = "jpg",
                        ImageBase64 = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAA9IAAAIzCAYAAADs/CFNAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcw...."
                    }
                }
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("UploadNewsletterImagesRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("AddCampaignRequest.xml")]
        public void SerializeAddCampaignRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();

            var request = new CampaignAddRequest
            {
                ApiKey = "44-121312131223",
                GroupId = 432,
                NewsletterId = 313,
                CampaignName = "Sample Campaign",
                SenderName = "My Name",
                SenderEmail = "myemail@address.com",
                Subject = "Welcome to my newsletter",
                StartDate = new DateTime(2014, 6, 1, 12, 0, 0)
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("AddCampaignRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("RetrieveCampaignsRequest.xml")]
        public void SerializeRetrieveCampaignsRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();

            var request = new RetrieveCampaignRequest
            {
                ApiKey = "44-121312131223",
                CampaignId = 4123
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("RetrieveCampaignsRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("CampaignsRequest.xml")]
        public void SerializeCampaignsRequest()
        {
            // Serialize request test for following api methods:
            // -GetOpenedEmails
            // -GetUnsubscribers
            // -GetBounces
            IXmlParser xmlParser = new DefaultXmlParser();

            var request = new CampaignRequest
            {
                ApiKey = "44-121312131223",
                CampaignId = 4124
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("CampaignsRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }

        [TestMethod]
        [DeploymentItem("CampaignsRequest.xml")]
        public void SerializeListClickedLinksRequest()
        {
            IXmlParser xmlParser = new DefaultXmlParser();

            var request = new LinkRequest
            {
                ApiKey = "44-121312131223",
                CampaignId = 4124
            };

            var requestXml = xmlParser.Serialize(request);
            var xml = File.ReadAllText("CampaignsRequest.xml");
            Assert.AreEqual(xml, requestXml);
        }
    }
}
