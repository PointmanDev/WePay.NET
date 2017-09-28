using System.Threading.Tasks;
using WePay.Shared;
using WePay.Risk.Request;
using WePay.Risk.Response;

namespace WePay.Risk
{
    /// <summary>
    /// The Risk API provides a way to communicate risk-related account and transaction level information between an application and WePay.
    /// An application and WePay will use this information to improve its risk decisioning process on both sides and provide better
    /// information to the user.
    /// All Risk API calls require WePay permission.
    /// An Rbit contains risk related information about your users, their accounts, and their transactions.
    /// </summary>
    public class RiskService : WePayApiService<RiskService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Find,
            Create,
            Delete,
        }

        /// <summary>
        /// This call allows you to lookup the details of a specific rbit on WePay using the RbitId.
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
        /// Use this call to create a new rbit for a user, account, or transaction.
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
        /// Use this call to search the rbits of the user associated with the access token used to make the call.
        /// Returns an array of matching rbits.
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

        /// <summary>
        /// Use this call to delete a specified Rbit.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="deleteRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<DeleteResponse> DeleteAsync(DeleteRequest deleteRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(deleteRequest, EndPointUrls.Delete, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "rbit";
            public const string Find = "rbit/find";
            public const string Create = "rbit/create";
            public const string Delete = "rbit/delete";
        }

        public RiskService(bool enableValidation = false,
                           string accessToken = null,
                           bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}