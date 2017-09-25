using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.Account.Request;
using WePayApi.Account.Response;

namespace WePayApi.Account
{
    public class AccountService : WePayApiService<AccountService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Find,
            Create,
            Modify,
            Delete,
            GetUpdateUri,
            SettlementSetup
        }

        /// <summary>
        /// Use this call to create a new payment account for the user associated with the access token used to make this call.
        /// </summary>
        /// <param name="createRequest"></param>
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
        /// Use this call to lookup the details of a payment account on WePay.
        /// The payment account must belong to the user associated with the access token used to make the call.
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
        /// Use this call to update the specified properties of the account. 
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
        /// Use this call delete an account.
        /// The user associated with the access token used must have permission to delete the account.
        /// An account may not be deleted if it has a balance or pending payments.
        /// Once the account is deleted, it will not appear in the results of a Find call, nor will you be able to un-delete the account.
        /// </summary>
        /// <param name="deleteRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<DeleteResponse> DeleteAsync(DeleteRequest deleteRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(deleteRequest, EndPointUrls.Delete, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to search the accounts of the user associated with the access token used to make the call.
        /// You can search by name or ReferenceId, and the response will be an array of all the matching accounts.
        /// If both Name and ReferenceId are blank, this will return an array of all of the user’s accounts.
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
        /// Use this call to add or update all incomplete items for an account such as Know Your Customer (KYC) or settlement info.
        /// It returns a URL that a user can visit to update information for their account.
        /// </summary>
        /// <param name="getUpdateUriRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<GetUpdateUriResponse> GetUpdateUriAsync(GetUpdateUriRequest getUpdateUriRequest,
                                                                  string accessToken = null,
                                                                  bool? useStaging = null)
        {
            return await PostRequestAsync(getUpdateUriRequest, EndPointUrls.GetUpdateUri, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to define how WePay settles funds to a merchant.
        /// Know Your Customer (KYC) information must be complete before making this call.
        /// PERMISSON REQUIRED
        /// </summary>
        /// <param name="settlementSetupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<SettlementSetupResponse> SettlementSetupAsync(SettlementSetupRequest settlementSetupRequest,
                                                                        string accessToken = null,
                                                                        bool? useStaging = null)
        {
            return await PostRequestAsync(settlementSetupRequest, EndPointUrls.GetUpdateUri, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "account";
            public const string Find = "account/find";
            public const string Create = "account/create";
            public const string Modify = "account/modify";
            public const string Delete = "account/delete";
            public const string GetUpdateUri = "account/get_update_uri";
            public const string SettlementSetup = "account/settlement_setup";
        }

        public AccountService(bool enableValidation = false,
                              string accessToken = null,
                              bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}