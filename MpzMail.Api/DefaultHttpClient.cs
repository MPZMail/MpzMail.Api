using MpzMail.Api.Contract;
using MpzMail.Api.Model;
using System.Net;
using System.Net.Http;
using System.Text;

namespace MpzMail.Api
{
    public class DefaultHttpClient : IHttpClient
    {
        public HttpResult Request(string url, string xml)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(xml, Encoding.UTF8, "application/xml");
                var task = httpClient.PostAsync(url, httpContent);
                task.Wait();
                if (task.IsCanceled || task.IsFaulted)
                {
                    return new HttpResult
                    {
                        Status = HttpStatus.Error,
                    };
                }

                if (task.Result.StatusCode != HttpStatusCode.OK)
                {
                    return new HttpResult
                    {
                        Status = HttpStatus.Error
                    };
                }

                var response = task.Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return new HttpResult
                    {
                        Status = HttpStatus.Error
                    };
                }

                if (task.Result.StatusCode == HttpStatusCode.OK)
                {
                    var responseTask = task.Result.Content.ReadAsStringAsync();
                    responseTask.Wait();
                    if (responseTask.IsCanceled || responseTask.IsFaulted)
                    {
                        return new HttpResult
                        {
                            Status = HttpStatus.Error
                        };
                    }

                    return new HttpResult
                    {
                        Status = HttpStatus.Successful,
                        Result = responseTask.Result
                    };
                }
            }

            return new HttpResult
            {
                Status = HttpStatus.Error,
            };
        }
    }
}
