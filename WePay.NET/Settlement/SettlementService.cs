using System.Threading.Tasks;
using WePay.Shared;
using WePay.Settlement.Request;
using WePay.Settlement.Response;

namespace WePay.Settlement
{
    public class SettlementService : WePayApiService<SettlementService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Create = 0,
            Authorize
        }

        /// <summary>
        /// This call creates a new settlement bank account object which can be safely referred to using the returned SettlementBankId.
        /// This API call should be invoked using the WePay JavaScript library.
        /// However, if you are making this call from a server, you should include the optional Risk Headers on this API call.
        /// CAUTION: Do not provide an access token for this call.
        /// Instead, it must be confirmed using the Authorize call within 30 minutes of creation.
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<CreateResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);
        }

        /// <summary>
        /// After a bank account has been defined using the Create call, it must be authorized within 30 minutes using the server-to-server Authorize call.
        /// When making this call, you must use the access token associated with the merchant.
        /// </summary>
        /// <param name="authorizeRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<AuthorizeResponse> AuthorizeAsync(AuthorizeRequest authorizeRequest,
                                                            string accessToken = null,
                                                            bool? useStaging = null)
        {
            return await PostRequestAsync(authorizeRequest, EndPointUrls.Authorize, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Create = "settlement_bank/create";
            public const string Authorize = "settlement_bank/authorize";
        }

        public SettlementService(bool enableValidation = false,
                                 string accessToken = null,
                                 bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}