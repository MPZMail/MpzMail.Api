using MpzMail.Api.Contract;
using MpzMail.Api.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MpzMail.Api
{
    public class DefaultHttpClient : IHttpClient
    {
        private readonly int _timeout;
        public DefaultHttpClient(int timeoutInSeconds = 300)
        {
            this._timeout = timeoutInSeconds;
        }

        public HttpResult Request(string url, string xml)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(0, 0, this._timeout);
                var httpContent = new StringContent(xml, Encoding.UTF8, "application/xml");
                try
                {
                    var task = Task.Run(() => httpClient.PostAsync(url, httpContent)); 
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

                    if (response.StatusCode == HttpStatusCode.OK)
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
                catch (Exception exception)
                {
                    return new HttpResult
                    {
                        Status = HttpStatus.Error,
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
