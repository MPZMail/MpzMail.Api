using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MpzMail.Api.Contract;
using MpzMail.Api.Model.Base;
using MpzMail.Api.Model;

namespace MpzMail.Api.UnitTest
{
    [TestClass]
    public class XmlParser
    {
        [TestMethod]
        [DeploymentItem("BaseRequest.xml")]
        public void BaseRequestSerialize()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var request = new BaseRequest
            {
                ApiKey = "44-121312131223"
            };

            var serializedRequest = xmlParser.Serialize(request);
            var expected = File.ReadAllText("BaseRequest.xml");
            Assert.AreEqual(expected, serializedRequest);
        }

        [TestMethod]
        [DeploymentItem("CampaignResult.xml")]
        public void DeserializeCampaignResult()
        {
            IXmlParser xmlParser = new DefaultXmlParser();
            var resultXml = File.ReadAllText("CampaignResult.xml");
            var result = xmlParser.Deserialize<CampaignResult>(resultXml);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(null, result.Campaigns);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        [DeploymentItem("")]
        public void GetCampaignsWithFilter()
        {
            IXmlParser xmlParser = new DefaultXmlParser();

        }
    }
}
