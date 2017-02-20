using MpzMail.Api.Model;

namespace MpzMail.Api.Contract
{
    public interface IHttpClient
    {
        HttpResult Request(string url, string xml);
    }
}
