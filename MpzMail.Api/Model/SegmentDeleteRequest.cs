﻿using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class SegmentDeleteRequest : BaseRequest
    {
        [XmlElement("groupID")]
        public int GroupId { get; set; }
        [XmlElement("segmentID")]
        public int SegmentId { get; set; }
    }
}
