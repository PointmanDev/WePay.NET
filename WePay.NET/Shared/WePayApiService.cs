using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WePay.Shared
{
    public abstract class WePayApiService
    {
        private const string WePayApiVersion = "v2/";
        private const string StagingUrlPrefix = "https://stage.wepayapi.com/";
        private const string ProductionUrlPrefix = "https://wepayapi.com/";
        private const string JsonMediaType = "application/json";
        private const string UserAgentHeaderKey = "User-Agent";
        private const string UserAgentHeaderValue = "WePay v2 WePay.NET";
        private static readonly Formatting Formatting = new Formatting();

        private static readonly DefaultContractResolver DefaultContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        };

        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = DefaultContractResolver,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        };

        private static readonly JsonSerializer JsonSerializer = new JsonSerializer()
        {
            ContractResolver = DefaultContractResolver
        };

        protected const string ErrorCodeKey = "error_code";

        public readonly List<string> EndPoints = new List<string>();
        public bool EnableValidation { get; set; }
        public string AccessToken { get; set; }
        public bool UseStaging { get; set; }

        private string GenerateWePayEndPointUrl(string wePayEndPoint,
                                                bool? useStaging)
        {
            return ((useStaging == null && UseStaging) || (useStaging != null && useStaging.Value) ? StagingUrlPrefix : ProductionUrlPrefix) + WePayApiVersion + wePayEndPoint;
        }

        private Exception GetExceptionFromErrorResponse(JObject response)
        {
            var wePayError = response.ToObject<WePayError>(JsonSerializer);
            var message = GetType().FullName + " - WePay.Shared.WePayError";

            if (wePayError != null)
            {
                message += "\nError: "
                    + wePayError.Error
                    + "\nError Description: "
                    + wePayError.ErrorDescription
                    + "\nError Code: "
                    + wePayError.ErrorCode.ToString();
            }
            else
            {
                message += " - Unknown Error.";
            }

            var exception = new Exception(message);
            exception.Data.Add("WePayError", wePayError);

            return exception;
        }

        protected string GetExceptionMessage<T>(WePayRequest<T> Request,
                                                string accessToken) where T : WePayResponse
        {
            string message = null;

            if (accessToken == null || accessToken == "")
            {
                message = Request.GetType().FullName + " requires an Access Token.";
            }

            if (Request != null)
            {
                string subMessage = Request.ValidateRequest();

                if (subMessage != null)
                {
                    message = (message == null ? "" : message + "\n") + subMessage;
                }
            }

            return message;
        }

        protected async Task<T> PostRequestAsync<T>(WePayRequest<T> Request,
                                                    string wePayEndPoint,
                                                    string accessToken,
                                                    bool? useStaging) where T : WePayResponse
        {
            if (EnableValidation)
            {
                string message = GetExceptionMessage(Request, accessToken ?? AccessToken);

                if (message != null)
                {
                    throw new Exception(message);
                }
            }

            var json = await Task.Run(() => JsonConvert.SerializeObject(Request, Formatting, JsonSerializerSettings));
            var httpContent = new StringContent(json, Encoding.UTF8, JsonMediaType);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken ?? AccessToken ?? "");
                httpClient.DefaultRequestHeaders.Add(UserAgentHeaderKey, UserAgentHeaderValue);

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(GenerateWePayEndPointUrl(wePayEndPoint, useStaging), httpContent);
                JObject response = (JObject)JsonConvert.DeserializeObject(await httpResponseMessage.Content.ReadAsStringAsync(), JsonSerializerSettings);

                if ((int?)response[ErrorCodeKey] != null)
                {
                    throw GetExceptionFromErrorResponse(response);
                }
                else
                {
                    return response.ToObject<T>(JsonSerializer);
                }
            }
        }

        public string GetEndPointByIndex(int endPointIndex)
        {
            return EndPoints[endPointIndex];
        }
    }

    public abstract class WePayApiService<T> : WePayApiService
    {
        protected void MapEndPointUrlsToEndPoints(Type type)
        {
            EndPoints.Clear();

            foreach (var p in type.GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                var value = p.GetValue(null);
                EndPoints.Add((string)value);
            }
        }

        public string GetEndPointByName(T endPointNames)
        {
            return EndPoints[Convert.ToInt32(endPointNames)];
        }

        public WePayApiService(bool enableValidation = false,
                               string accessToken = null,
                               bool useStaging = false)
        {
            EnableValidation = enableValidation;
            AccessToken = accessToken;
            UseStaging = useStaging;
        }
    }
}