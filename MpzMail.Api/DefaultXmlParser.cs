using MpzMail.Api.Contract;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MpzMail.Api
{
    public class DefaultXmlParser : IXmlParser
    {
        private class NamespaceIgnorantXmlTextReader : XmlTextReader
        {
            public NamespaceIgnorantXmlTextReader(TextReader reader) : base(reader) { }

            public override string NamespaceURI
            {
                get { return string.Empty; }
            }
        }

        private class NamespaceIgnorantXmlTextWriter : XmlTextWriter
        {
            public NamespaceIgnorantXmlTextWriter(TextWriter writer) : base(writer) { }
            
        }

        public T Deserialize<T>(string xml)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var reader = new StringReader(xml))
                {
                    using (var xmlTextReader = new NamespaceIgnorantXmlTextReader(reader))
                    {
                        return (T)(serializer.Deserialize(xmlTextReader));
                    }
                }
            }
            catch (Exception exception)
            {
                return default(T);
            }
        }

        public string Serialize<T>(T obj)
        {
            try
            {
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;


                var xml = "";
                var serializer = new XmlSerializer(typeof(T));
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                using(var stringWriter = new StringWriter())
                {
                    using(var writer = XmlWriter.Create(stringWriter, settings))
                    {
                        serializer.Serialize(writer, obj, ns);
                        xml = stringWriter.ToString();
                    }
                }

                return xml;
            }
            catch (Exception exception)
            {
                return string.Empty;
            }
        }
    }
}
