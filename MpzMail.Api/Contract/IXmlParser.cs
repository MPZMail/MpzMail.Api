namespace MpzMail.Api.Contract
{
    public interface IXmlParser
    {
        T Deserialize<T>(string xml);
        string Serialize<T>(T obj);
    }
}
