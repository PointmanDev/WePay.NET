using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.Order.Request;
using WePayApi.Order.Response;

namespace WePayApi.Order
{
    /// <summary>
    /// The order resource is used as part of WePay’s mPOS program. An order is a request by a partner to have WePay ship a card reader to a merchant.
    /// PERMISSION REQUIRED: Please get in touch with your WePay account manager to use this API, or to learn more about WePay’s mPOS program.
    /// </summary>
    public class OrderService : WePayApiService<OrderService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Find,
            Create
        }

        /// <summary>
        /// Use this call to lookup the details of an mPOS card reader order on WePay.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LookupAsync(LookupRequest lookupRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Lookup, accessToken, useStaging);
        }

        /// <summary>
        /// Create a new order.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to search for all orders that match a certain OrderId.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="findRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<WePayFindResponse<LookupResponse>> FindAsync(FindRequest findRequest,
                                                                       string accessToken = null,
                                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(findRequest, EndPointUrls.Find, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "order";
            public const string Find = "order/find";
            public const string Create = "order/create";
        }

        public OrderService(bool enableValidation = false,
                            string accessToken = null,
                            bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}