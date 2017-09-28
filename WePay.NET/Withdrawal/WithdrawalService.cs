using System.Threading.Tasks;
using WePay.Shared;
using WePay.Withdrawal.Request;
using WePay.Withdrawal.Response;

namespace WePay.Withdrawal
{
    /// <summary>
    /// The withdrawal object represents a single payout to the user’s bank account or a check sent to the user.
    /// </summary>
    public class WithdrawalService : WePayApiService<WithdrawalService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Find,
            Modify
        }

        /// <summary>
        /// Use this call to lookup the details of a withdrawal.
        /// A withdrawal object represents the movement of money from a WePay account to a bank account.
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
        /// Use this call to change the CallbackUri on a withdrawal. 
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
        /// Use this call to find withdrawals made from a specified account.
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

        public static class EndPointUrls
        {
            public const string Lookup = "withdrawal";
            public const string Find = "withdrawal/find";
            public const string Modify = "withdrawal/modify";
        }

        public WithdrawalService(bool enableValidation = false,
                                 string accessToken = null,
                                 bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}