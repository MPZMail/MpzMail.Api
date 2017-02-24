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
    }
}
