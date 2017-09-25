using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.CreditCard.Request;
using WePayApi.CreditCard.Response;

namespace WePayApi.CreditCard
{
    /// <summary>
    /// The CreditCard object represents a user’s credit card and can be used to tokenize credit cards
    /// While WePay CC Tokenization API greatly reduces the scope of PCI Compliance and increases your security,
    /// your application is still required to be compliant with the Payment Card Industry Data Security Standards (PCI-DSS) and the Payment Application Data Security Standards (PA-DSS) whenever applicable.
    /// If you want to minimize the scope of your PCI compliance, we recommend that you use our iframe checkout.
    /// Use of the credit card tokenization feature requires special approval from WePay. Please apply for approval on your application’s dashboard.
    /// For more information about PCI standards and compliance, see the following link: https://www.pcisecuritystandards.org/.
    /// </summary>
    public class CreditCardService : WePayApiService<CreditCardService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Create,
            Authorize,
            Find,
            Modify,
            Transfer,
            Delete,
            EnableRecurring
        }

        /// <summary>
        /// This call allows you to pass credit card information and receive back a CreditCardId.
        /// You will then be able to use that CreditCardId on the Checkout Create call to execute a payment immediately with that credit card.
        /// Note that you will need to call the Checkout Create call or the CreditCard Authorize call within 30 minutes or the CreditCard object will expire.
        /// The credit card created by the CreditCard Create call is tokenized and the card details are immutable.
        /// TIP: If you pass an accessToken on this call, the credit card will be added to the user associated with that accessToken.
        /// If you want to do a guest payment(ie the payer is not registered on WePay), then do not pass an accessToken.
        /// TIP: User contact information(especially e-mail) is key for risk analysis, so please make sure you provide the actual end-user contact information.
        /// PERMISSION REQUIRED: Cvv is optional only if the app has the correct permissions.
        /// Please speak to your account manager for more information.
        /// </summary>
        /// <param name="createResponse"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to lookup the details of a credit card that you have tokenized.
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
        /// You should only use this call if you are not going to immediately make the Checkout Create call with the CreditCardId.
        /// This call authorizes the card and allows you use it at a later time or date(for crowdfunding, subscriptions, etc.).
        /// If you don’t call CreditCard Authorize or Checkout Create within 30 minutes, the CreditCard object will expire.
        /// </summary>
        /// <param name="authorizeRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> AuthorizeAsync(AuthorizeRequest authorizeRequest,
                                                         string accessToken = null,
                                                         bool? useStaging = null)
        {
            return await PostRequestAsync(authorizeRequest, EndPointUrls.Authorize, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to search through tokenized credit cards.
        /// The response is an array of credit cards matching the search parameters. 
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

        /// <summary>
        /// Use this call to make modifications to an existing tokenized credit card. 
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> ModifyAsync(ModifyRequest modifyRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(modifyRequest, EndPointUrls.Modify, accessToken, useStaging);
        }

        /// <summary>
        /// This call is similar to CreditCard Create.
        /// It is intended to be used server-server for the purpose of migrating credit card information to WePay.
        /// If AutoAuthorize is set to true, WePay will automatically test cards transferred to us via CreditCard Transfer by making a $0.00 authorization (in rare instances, the authorization amount may be $1.00 instead).
        /// All payment error codes (200X) are possible return values for CreditCard Transfer.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="transferRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<StateResponse> TransferAsync(TransferRequest transferRequest,
                                                       string accessToken = null,
                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(transferRequest, EndPointUrls.Transfer, accessToken, useStaging);
        }

        /// <summary>
        /// Delete the credit card when you don’t need it anymore.
        /// TIP: Once a credit card is deleted the card will no longer be available to make payments.
        /// WARNING: Do not delete a credit card before the state of the Checkout == captured.
        /// </summary>
        /// <param name="deleteRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<StateResponse> DeleteAsync(DeleteRequest deleteRequest,
                                                     string accessToken = null,
                                                     bool? useStaging = null)
        {
            return await PostRequestAsync(deleteRequest, EndPointUrls.Delete, accessToken, useStaging);
        }

        /// <summary>
        /// Enable an EMV card to make recurring payments.
        /// WARNING: If you intend to make a charge on the physically present card,
        /// do not call EnableRecurring until after the original Checkout Create call has been made successfully against the card present checkout.
        /// </summary>
        /// <param name="enableRecurringRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<SimpleResponse> EnableRecurringAsync(EnableRecurringRequest enableRecurringRequest,
                                                               string accessToken = null,
                                                               bool? useStaging = null)
        {
            return await PostRequestAsync(enableRecurringRequest, EndPointUrls.EnableRecurring, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "credit_card";
            public const string Create = "credit_card/create";
            public const string Authorize = "credit_card/authorize";
            public const string Find = "credit_card/find";
            public const string Modify = "credit_card/modify";
            public const string Transfer = "credit_card/transfer";
            public const string Delete = "credit_card/delete";
            public const string EnableRecurring = "credit_card/enable_recurring";
        }

        public CreditCardService(bool enableValidation = false,
                                 string accessToken = null,
                                 bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}