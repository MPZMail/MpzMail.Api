using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [Serializable]
    public enum FileExtension
    {
        [XmlEnum("png")]
        PNG = 0,
        [XmlEnum("gif")]
        GIF = 1,
        [XmlEnum("jpg")]
        JPG = 2
    }
}
