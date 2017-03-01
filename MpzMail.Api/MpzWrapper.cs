using MpzMail.Api.Contract;
using MpzMail.Api.Model;
using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MpzMail.Api
{
    public class MpzWrapper : IMpzWrapper
    {
        private IHttpClient _httpClient;
        private IXmlParser _parser;
        private string _apiKey;
        private string _baseUrl;

        public MpzWrapper(IXmlParser xmlParser, IHttpClient httpClient, string apiKey, string baseUrl)
        {
            this._httpClient = httpClient;
            this._parser = xmlParser;
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        #region AccountFunctions
        public AccountResult CreateAccount(string emailAddres, string password, string fullname, AccountOptions options)
        {
            var url = $"{this._baseUrl}/account/createaccount/";
            var request = new AccountRequest
            {
                ApiKey = this._apiKey,
                EmailAddress = emailAddres,
                Password = password,
                Fullname = fullname,
            };

            if (options != null)
            {
                if (!string.IsNullOrEmpty(options.AgencyId))
                {
                    request.AgencyId = options.AgencyId;
                }

                if (options.AgencyAccount.HasValue)
                {
                    request.AgencyAccount = options.AgencyAccount.Value;
                }

                if (options.Type.HasValue)
                {
                    request.Type = options.Type.Value;
                }
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new AccountResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var result = this._parser.Deserialize<AccountResult>(httpResponse.Result);
            return result;
        }

        public BaseResult TransferCredits(int recipientId, int credits)
        {
            var url = $"{this._baseUrl}/account/transferCredits/";
            var request = new TransferCreditRequest
            {
                ApiKey = this._apiKey,
                Credits = credits,
                RecipientId = recipientId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var result = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return result;
        }
        #endregion

        #region Campaigns

        public CampaignAddResult AddCampaign(CampaignAddRequest campaignToAdd)
        {
            campaignToAdd.ApiKey = this._apiKey;
            var url = $"{this._baseUrl}/campaigns/addCampaign/";
            var xml = this._parser.Serialize<CampaignAddRequest>(campaignToAdd);
            var httpResponse = this._httpClient.Request(url, xml);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignAddResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }
            var result = this._parser.Deserialize<CampaignAddResult>(httpResponse.Result);
            return result;
        }

        public CampaignResult GetCampaigns()
        {
            var url = $"{this._baseUrl}/campaigns/listCampaigns/";
            var request = new BaseRequest
            {
                ApiKey = this._apiKey
            };

            var requestXml = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, requestXml);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var mailingResult = this._parser.Deserialize<CampaignResult>(httpResponse.Result);
            return mailingResult;
        }

        public CampaignResult GetCampaigns(DateFilter filter)
        {
            if (filter == null)
            {
                return new CampaignResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/campaigns/listCampaigns/";
            var request = new CampaignRequest
            {
                ApiKey = this._apiKey,
            };

            if (filter.FromDate.HasValue)
            {
                request.FromDate = filter.FromDate.Value;
            }

            if (filter.ToDate.HasValue)
            {
                request.ToDate = filter.ToDate.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignResult
                {
                    Status = Status.Error,
                    Message = "Http error",
                };
            }

            var mailingResult = this._parser.Deserialize<CampaignResult>(httpResponse.Result);
            return mailingResult;
        }

        public CampaignRetrieveResult GetCampaign(int campaignId)
        {
            var url = $"{this._baseUrl}/campaigns/viewCampaign/";
            var request = new RetrieveCampaignRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId,
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignRetrieveResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var campaignResult = this._parser.Deserialize<CampaignRetrieveResult>(httpResponse.Result);
            return campaignResult;
        }

        public CampaignSubscriberResult GetOpenedEmails(int campaignId)
        {
            var url = $"{this._baseUrl}/campaigns/listOpens/";
            var request = new RetrieveCampaignRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }
            var subscriberResult = this._parser.Deserialize<CampaignSubscriberResult>(httpResponse.Result);
            return subscriberResult;
        }

        public CampaignSubscriberResult GetOpenedEmails(int campaignId, DateFilter filter)
        {
            if (filter == null)
            {
                new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/campaigns/listOpens/";
            var request = new CampaignRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId
            };

            if (filter.FromDate.HasValue)
            {
                request.FromDate = filter.FromDate.Value;
            }

            if (filter.ToDate.HasValue)
            {
                request.ToDate = filter.ToDate.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }
            var subscriberResult = this._parser.Deserialize<CampaignSubscriberResult>(httpResponse.Result);
            return subscriberResult;
        }

        public LinkResult GetClickedLinks(int campaignId)
        {
            var url = $"{this._baseUrl}/campaigns/listClicks/";
            var request = new LinkRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new LinkResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var linkResult = this._parser.Deserialize<LinkResult>(httpResponse.Result);
            return linkResult;
        }

        public LinkResult GetClickedLinks(int campaignId, LinkFilter filter)
        {
            if (filter == null)
            {
                return new LinkResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/campaigns/listClicks/";

            var request = new LinkRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId,
            };

            if (filter.Type.HasValue)
            {
                request.TrackingType = filter.Type.Value;
            }

            if (filter.FromDate.HasValue)
            {
                request.FromDate = filter.FromDate.Value;
            }

            if (filter.ToDate.HasValue)
            {
                request.ToDate = filter.ToDate.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new LinkResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var linkResult = this._parser.Deserialize<LinkResult>(httpResponse.Result);
            return linkResult;
        }

        public UnsubscriberResult GetUnsubscribers(int campaignId)
        {
            var url = $"{this._baseUrl}/campaigns/listUnsubscribers/";
            var request = new RetrieveCampaignRequest
            {
                ApiKey = this._baseUrl,
                CampaignId = campaignId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new UnsubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscriberResult = this._parser.Deserialize<UnsubscriberResult>(httpResponse.Result);
            return unsubscriberResult;
        }

        public UnsubscriberResult GetUnsubscribers(int campaignId, DateFilter filter)
        {
            if (filter == null)
            {
                return new UnsubscriberResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/campaigns/listUnsubscribers/";
            var request = new CampaignRequest
            {
                ApiKey = this._baseUrl,
                CampaignId = campaignId
            };

            if (filter.FromDate.HasValue)
            {
                request.FromDate = filter.FromDate.Value;
            }

            if (filter.ToDate.HasValue)
            {
                request.ToDate = filter.ToDate.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new UnsubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscriberResult = this._parser.Deserialize<UnsubscriberResult>(httpResponse.Result);
            return unsubscriberResult;
        }

        public CampaignSubscriberResult GetBounces(int campaignId)
        {
            var url = $"{this._baseUrl}/campaigns/listBounces/";
            var request = new RetrieveCampaignRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var subscriberResult = this._parser.Deserialize<CampaignSubscriberResult>(httpResponse.Result);
            return subscriberResult;
        }

        public CampaignSubscriberResult GetBounces(int campaignId, DateFilter filter)
        {
            if (filter == null)
            {
                return new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/campaigns/listBounces/";
            var request = new CampaignRequest
            {
                ApiKey = this._apiKey,
                CampaignId = campaignId,
            };

            if (filter.FromDate.HasValue)
            {
                request.FromDate = filter.FromDate.Value;
            }

            if (filter.ToDate.HasValue)
            {
                request.ToDate = filter.ToDate.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CampaignSubscriberResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var subscriberResult = this._parser.Deserialize<CampaignSubscriberResult>(httpResponse.Result);
            return subscriberResult;
        }

        #endregion

        #region Newsletters
        public NewsletterAddResult AddNewsletter(string newsletterName, string htmlBody)
        {
            var url = $"{this._baseUrl}/newsletters/addNewsletter/";
            var request = new NewsletterAddRequest
            {
                ApiKey = this._apiKey,
                NewsletterName = newsletterName,
                Html = htmlBody
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new NewsletterAddResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var newsletterResult = this._parser.Deserialize<NewsletterAddResult>(httpResponse.Result);
            return newsletterResult;
        }

        public NewsletterUploadImageResult UploadNewsletterImages(List<FileRequest> files)
        {
            var url = $"{this._baseUrl}/newsletters/addImages/";
            var request = new NewsletterUpdloadImageRequest
            {
                ApiKey = this._apiKey,
                Files = files
            };

            var requestXml = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, requestXml);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new NewsletterUploadImageResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var uploadImageResult = this._parser.Deserialize<NewsletterUploadImageResult>(httpResponse.Result);
            return uploadImageResult;
        }

        public NewsletterListResult GetNewsletters()
        {
            var url = $"{this._baseUrl}/newsletters/listNewsletters/";
            var request = new BaseRequest
            {
                ApiKey = this._apiKey
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new NewsletterListResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var newsletterResult = this._parser.Deserialize<NewsletterListResult>(httpResponse.Result);
            return newsletterResult;
        }
        #endregion

        #region Forms
        public FormResult GetForms()
        {
            var url = $"{this._baseUrl}/forms/listForms/";
            var request = new BaseRequest
            {
                ApiKey = this._apiKey
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new FormResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var formResult = this._parser.Deserialize<FormResult>(httpResponse.Result);
            return formResult;
        }
        #endregion

        #region Subscribers
        public SubscriberAddResult AddSubscribers(int groupId, bool? returnCustomFields, List<Subscriber> subscribers)
        {
            var url = $"{this._baseUrl}/subscribers/addSubscribers/";
            var request = new SubscriberAddRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId,
                Subscribers = subscribers,
                ReturnCustomFields = returnCustomFields
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SubscriberAddResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var subscriberResult = this._parser.Deserialize<SubscriberAddResult>(httpResponse.Result);
            return subscriberResult;
        }

        public SubscriberListResult GetSubscribers(int groupId, SubscriberFilter filter)
        {
            if (filter == null)
            {
                return new SubscriberListResult
                {
                    Status = Status.Error,
                    Message = "Filter is null"
                };
            }

            var url = $"{this._baseUrl}/subscribers/listSubscribers/";
            var request = new SubscriberListRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId,
            };
            if (filter.NumberOfSubscribersToReturn.HasValue)
            {
                request.SubscriberCountToReturn = filter.NumberOfSubscribersToReturn.Value;
            }

            if (!string.IsNullOrEmpty(filter.PartOfOrWholeEmail))
            {
                request.PartOfOrWholeEmail = filter.PartOfOrWholeEmail;
            }

            if (filter.SortBy.HasValue)
            {
                request.FieldToSortBy = filter.SortBy.Value;
            }

            if (filter.SortOrder.HasValue)
            {
                request.DirectionToSortBy = filter.SortOrder.Value;
            }

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SubscriberListResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var subscriberListResult = this._parser.Deserialize<SubscriberListResult>(httpResponse.Result);
            return subscriberListResult;
        }

        public UnsubscriberListResult ListUnsubscribers(int groupId, DateFilter filter)
        {
            var request = new UnsubscriberListRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId
            };

            if (filter != null)
            {
                if (filter.FromDate.HasValue)
                {
                    request.StartDate = filter.FromDate.Value;
                }

                if (filter.ToDate.HasValue)
                {
                    request.EndDate = filter.ToDate.Value;
                }
            }

            var url = $"{this._baseUrl}/subscribers/listUnsubscribers/";
            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new UnsubscriberListResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscriberResult = this._parser.Deserialize<UnsubscriberListResult>(httpResponse.Result);
            return unsubscriberResult;
        }

        public BaseResult UpdateSubscriber(int groupId, int subscriberId, string firstName, string lastName, string companyName)
        {
            var url = $"{this._baseUrl}/subscribers/updateSubscriber/";
            var request = new SubscriberUpdateRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId,
                SubscriberId = subscriberId,
                FirstName = firstName,
                LastName = lastName,
                CompanyName = companyName
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var updateResult = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return updateResult;
        }

        public BaseResult UnsubscribeSubscriberFromAllGroups(string emailAddress)
        {
            var url = $"{this._baseUrl}/subscribers/unsubscribe/";
            var request = new SubscriberUnsubscribeRequest
            {
                ApiKey = this._apiKey,
                Email = emailAddress
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscribeResult = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return unsubscribeResult;
        }

        public BaseResult UnsubscribeSubscriberFromAllGroups(int subscriberId)
        {
            var url = $"{this._baseUrl}/subscribers/unsubscribe/";
            var request = new SubscriberUnsubscribeRequest
            {
                ApiKey = this._apiKey,
                SubscriberId = subscriberId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscribeResult = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return unsubscribeResult;
        }

        public BaseResult UnsubscribeSubscriberFromSpecificGroup(string emailAddress, int groupId, ReturnAllFields returnWithCustomFields)
        {
            var url = $"{this._baseUrl}/subscribers/unsubscribe/";
            var request = new SubscriberUnsubscribeRequest
            {
                ApiKey = this._apiKey,
                Email = emailAddress,
                GroupId = groupId,
                ReturnWithCustomFields = returnWithCustomFields
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscribeResult = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return unsubscribeResult;
        }

        public BaseResult UnsubscribeSubscriberFromSpecificGroup(int subscriberId, int groupId, ReturnAllFields returnWithCustomFields)
        {
            var url = $"{this._baseUrl}/subscribers/unsubscribe/";
            var request = new SubscriberUnsubscribeRequest
            {
                ApiKey = this._apiKey,
                SubscriberId = subscriberId,
                GroupId = groupId,
                ReturnWithCustomFields = returnWithCustomFields
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new BaseResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var unsubscribeResult = this._parser.Deserialize<BaseResult>(httpResponse.Result);
            return unsubscribeResult;
        }

        public SubscriberBulkAddResult BulkAddSubscribers(int groupId, List<Subscriber> subscribers)
        {
            var csv = new StringBuilder();
            var firstLine = "email,firstname,lastName,companyName,houseNo,address1,address2,town,county,country,postCode,dateOfBirth,gender,customField1,customField2,customField3,customField4,customField5,customField6,customField7,customField8,customField9,customField10";
            csv.Append(firstLine);
            var csvSubscribersBase64Encoded = string.Empty;
            foreach (var subscriber in subscribers)
            {
                csv.Append("\r\n");
                var subscriberToString = subscriber.ToString();
                csv.Append(subscriberToString);
            }

            var bytes = Utf8Encode(csv.ToString());
            if (bytes.Length > 22499919) // max bytes: 22.499.919
            {
                return new SubscriberBulkAddResult
                {
                    Status = Status.Error,
                    Message = "Too many subscribers"
                };
            }

            csvSubscribersBase64Encoded = Base64Encode(bytes);
            var url = $"{this._baseUrl}/subscribers/bulkSubscribers/";
            var request = new SubscriberBulkAddRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId,
                CsvSubscribersBase65Encoded = csvSubscribersBase64Encoded
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SubscriberBulkAddResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var bulkAddResult = this._parser.Deserialize<SubscriberBulkAddResult>(httpResponse.Result);
            return bulkAddResult;
        }

        public string Base64Encode(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public byte[] Utf8Encode(string plainText)
        {
            return Encoding.UTF8.GetBytes(plainText);
        }

        public SubscriberBulkImportResult QueryBulkImport(int importId)
        {
            var url = $"{this._baseUrl}/subscribers/bulkQuery/";
            var request = new SubscriberBulkQueryRequest
            {
                ApiKey = this._apiKey,
                ImportId = importId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SubscriberBulkImportResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var internalResult = this._parser.Deserialize<SubscriberInternalBulkImportResult>(httpResponse.Result);
            var separator = new string[] { "//" };
            var duplicateEmailAddresses = internalResult.Job.DuplicateEmailAddresses.Split(separator, StringSplitOptions.None).ToList();
            var invalidEmailAddresses = internalResult.Job.InvalidEmailAddresses.Split(separator, StringSplitOptions.None).ToList();
            var previouslyUnsubscribedEmailAddresses = internalResult.Job.PreviouslyUnsubscribedEmailAddresses.Split(separator, StringSplitOptions.None).ToList();
            return new SubscriberBulkImportResult
            {
                Status = internalResult.Status,
                Job = new Job
                {
                    DetectedSubscribersCount = internalResult.Job.DetectedSubscribersCount,
                    DuplicateEmailAddressesCount = internalResult.Job.DuplicateEmailAddressesCount,
                    ProcessedSubscribersCount = internalResult.Job.ProcessedSubscribersCount,
                    PreviouslyUnsubscribedEmailAddressesCount = internalResult.Job.PreviouslyUnsubscribedEmailAddressesCount,
                    Status = internalResult.Job.Status,
                    InvalidEmailAddresssesCount = internalResult.Job.InvalidEmailAddressesCount,
                    DuplicateEmailAddresses = duplicateEmailAddresses,
                    InvalidEmailAddresses = invalidEmailAddresses,
                    PreviouslyUnsubscribedEmailAddresses = previouslyUnsubscribedEmailAddresses
                },
                Message = internalResult.Message
            };
        }

        public SegmentResult AddSegment(string segmentName, SegmentFilter filter)
        {
            var url = $"{this._baseUrl}/groups/addSegment/";
            var request = new SegmentAddRequest
            {
                ApiKey = this._apiKey,
                GroupId = filter.GroupId,
                MatchType = filter.MatchType,
                Name = segmentName,
                Rules = new List<SegmentRule>()
            };

            request.Rules = GetRules(filter);

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SegmentResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var result = this._parser.Deserialize<SegmentResult>(httpResponse.Result);

            return result;
        }

        public SegmentResult UpdateSegment(int segmentId, SegmentFilter filter)
        {
            var url = $"{this._baseUrl}/groups/updateSegment/";
            var request = new SegmentUpdateRequest
            {
                ApiKey = this._apiKey,
                GroupId = filter.GroupId,
                Id = segmentId,
                MatchType = filter.MatchType,
                Rules = new List<SegmentRule>()
            };

            request.Rules = GetRules(filter);
            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SegmentResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var result = this._parser.Deserialize<SegmentResult>(httpResponse.Result);

            return result;
        }

        public SegmentResult DeleteSegment(int groupId, int segmentId)
        {
            var url = $"{this._baseUrl}/groups/deleteSegment/";
            var request = new SegmentDeleteRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId,
                SegmentId = segmentId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SegmentResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var result = this._parser.Deserialize<SegmentResult>(httpResponse.Result);
            return result;
        }

        private List<SegmentRule> GetRules(SegmentFilter filter)
        {
            var result = new List<SegmentRule>();
            if (filter.DateFilters != null)
            {
                foreach (var dateFilter in filter.DateFilters)
                {
                    SegmentField field;
                    Enum.TryParse(dateFilter.FieldType.ToString(), out field);
                    SegmentModifier modifier;
                    Enum.TryParse(dateFilter.Modifier.ToString(), out modifier);
                    result.Add(new SegmentRule
                    {
                        Field = field,
                        Modifier = modifier,
                        Value = dateFilter.Value
                    });
                }
            }

            if (filter.NumberTextFilters != null)
            {
                foreach (var numberTextFilter in filter.NumberTextFilters)
                {
                    SegmentField field;
                    Enum.TryParse(numberTextFilter.FieldType.ToString(), out field);
                    SegmentModifier modifier;
                    Enum.TryParse(numberTextFilter.Modifier.ToString(), out modifier);
                    result.Add(new SegmentRule
                    {
                        Field = field,
                        Modifier = modifier,
                        Value = numberTextFilter.Value
                    });
                }
            }

            return result;
        }


        #endregion

        #region Groups
        public GroupAddResult AddGroup(string groupName)
        {
            var url = $"{this._baseUrl}/groups/addGroup/";
            var request = new GroupAddRequest
            {
                ApiKey = this._apiKey,
                GroupName = groupName
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new GroupAddResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var groupResult = this._parser.Deserialize<GroupAddResult>(httpResponse.Result);
            return groupResult;
        }

        public GroupDeleteGroupResult DeleteGroup(string groupId)
        {
            var url = $"{this._baseUrl}/groups/deleteGroup/";
            var request = new GroupDeleteRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new GroupDeleteGroupResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var groupResult = this._parser.Deserialize<GroupDeleteGroupResult>(httpResponse.Result);
            return groupResult;
        }

        public GroupListResult GetGroups()
        {
            var url = $"{this._baseUrl}/groups/listGroups/";
            var request = new BaseRequest
            {
                ApiKey = this._apiKey
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new GroupListResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var groupResult = this._parser.Deserialize<GroupListResult>(httpResponse.Result);
            return groupResult;
        }

        public SegmentListResult GetSegments(string groupId)
        {
            var url = $"{this._baseUrl}/groups/listSegments/";
            var request = new SegmentListRequest
            {
                ApiKey = this._apiKey,
                GroupId = groupId
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new SegmentListResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var segmentResult = this._parser.Deserialize<SegmentListResult>(httpResponse.Result);
            return segmentResult;
        }
        #endregion

        #region Customers
        public CustomerResult GetCustomers()
        {
            var url = $"{this._baseUrl}/account/getCustomers/";
            var request = new BaseRequest
            {
                ApiKey = this._apiKey
            };

            var xmlRequest = this._parser.Serialize(request);
            var httpResponse = this._httpClient.Request(url, xmlRequest);
            if (httpResponse.Status != HttpStatus.Successful)
            {
                return new CustomerResult
                {
                    Status = Status.Error,
                    Message = "Http error"
                };
            }

            var customerResult = this._parser.Deserialize<CustomerResult>(httpResponse.Result);
            return customerResult;
        }
        #endregion
    }
}
