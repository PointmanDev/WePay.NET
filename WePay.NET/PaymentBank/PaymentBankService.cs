using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.PaymentBank.Request;
using WePayApi.PaymentBank.Response;

namespace WePayApi.PaymentBank
{
    /// <summary>
    /// The payment_bank object represents a bank account that is tokenized from the tokenization.3.latest.js library and is used for payments.
    /// </summary>
    public class PaymentBankService : WePayApiService<PaymentBankService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Persist
        }

        /// <summary>
        /// Use this call to look up the details of a payment bank.
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
        /// Use this call when you want to save a bank account on your platform for later use as a payment method, without calling Checkout Create now.
        /// If the payer has already verified the bank account, it will be available immediately for use as a payment method.
        /// If the payer has not verified the bank account, this call will initiate the sending of micro-deposits.
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> PersistAsync(LookupRequest lookupRequest,
                                                       string accessToken = null,
                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Persist, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "payment_bank";
            public const string Persist = "payment_bank/persist";
        }

        public PaymentBankService(bool enableValidation = false,
                                  string accessToken = null,
                                  bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}