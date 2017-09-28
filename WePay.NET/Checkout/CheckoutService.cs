using System.Threading.Tasks;
using WePay.Shared;
using WePay.Checkout.Request;
using WePay.Checkout.Response;

namespace WePay.Checkout
{
    /// <summary>
    /// The checkout object represents a single payment and defines the amount, the destination account, the application fee, etc
    /// </summary>
    public class CheckoutService : WePayApiService<CheckoutService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Find,
            Create,
            Cancel,
            Refund,
            Capture,
            Modify,
            Release
        }

        /// <summary>
        /// Use this call to create a checkout for an account.
        /// There are two ways to have your customers make a payment.
        /// You can have the checkout URL hosted by WePay or you can use a previously acquired payment method, such as a credit card. 
        /// WePay highly recommends using unique_id to manage timeouts on Create. 
        /// The UniqueId is used to prevent accidental duplicate calls in the case of an unsuccessful call.
        /// If a UniqueId is repeated and the Create call appears to be duplicate (the amount, AccountId, and ClientId are identical to the prior call),
        /// we will return the response of the prior Create call.
        /// Otherwise, we will return an error.
        /// 1) If your call times out, you can safely call it any number of times with the same UniqueId, and we will only process it once.
        /// 2) If your call receives a 1008 error code and an error message(there was an unknown error - please contact api @wepay.com for support), the request should be resubmitted with the same UniqueId.
        /// 3) If your call receives any other error, you will need a new UniqueId when you fix and resubmit the request.
        /// TIP: Checkouts expire 30 minutes after they are created if there is no activity on them (e.g. they were abandoned after creation).
        /// NOTE: Supplying rbits helps improve your experience and the experience of your users. You may be contractually required to include rbit information in your requests (despite being optional at the API level).
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool useStaging = false)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to modify the callback_uri of a checkout.
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> ModifyAsync(ModifyRequest modifyRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(modifyRequest, EndPointUrls.Modify, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to lookup the details of a specific checkout on WePay using the CheckoutId.
        /// Not all response parameters appear in the response: those which do not appear have no associated values.
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LookupAsync(LookupRequest lookupRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Lookup, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to search for checkouts associated with an account.
        /// This call returns an array of checkouts associated with AccountId.
        /// </summary>
        /// <param name="findRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<WePayFindResponse<LookupResponse>> FindAsync(FindRequest findRequest,
                                                                       string accessToken = null,
                                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(findRequest, EndPointUrls.Find, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to cancel a payment associated with the checkout created by the application.
        /// Checkout must be in authorized or captured state.
        /// The Cancel call cannot be used on Pay With Bank (ACH) payments.
        /// </summary>
        /// <param name="cancelRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<StateResponse> CancelAsync(CancelRequest cancelRequest,
                                                     string accessToken = null,
                                                     bool? useStaging = null)
        {
            return await PostRequestAsync(cancelRequest, EndPointUrls.Cancel, accessToken, useStaging);
        }

        /// <summary>
        /// If AutoCapture for a credit card based payment method was set to false when the checkout was created,
        /// you will need to make this call to capture funds.
        /// Until you make this call, the credit card will not be charged and if you do not capture the funds within 7 days then the payment will be automatically cancelled.
        /// You can only make this call if the checkout is in state authorized.
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> CaptureAsync(LookupRequest lookupRequest,
                                                       string accessToken = null,
                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Capture, accessToken, useStaging);
        }

        /// <summary>
        /// If AutoRelease was set to false when the checkout was created, you will need to make this call to release funds to the account.
        /// Until you make this call, the money will be held by WePay and if you do not release the funds within 14 days then the payment will be automatically cancelled or refunded.
        /// You can only make this call if the checkout is in state captured.
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> ReleaseAsync(LookupRequest lookupRequest,
                                                       string accessToken = null,
                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Release, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to refund the payment associated with the checkout created by the application.
        /// Checkout must be in released state.
        /// </summary>
        /// <param name="refundRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<StateResponse> RefundAsync(RefundRequest refundRequest,
                                                     string accessToken = null,
                                                     bool? useStaging = null)
        {
            return await PostRequestAsync(refundRequest, EndPointUrls.Refund, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "checkout";
            public const string Find = "checkout/find";
            public const string Create = "checkout/create";
            public const string Cancel = "checkout/cancel";
            public const string Refund = "checkout/refund";
            public const string Capture = "checkout/capture";
            public const string Modify = "checkout/modify";
            public const string Release = "checkout/release";
        }

        public CheckoutService(bool enableValidation = false,
                               string accessToken = null,
                               bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}