using System.Threading.Tasks;
using WePay.Shared;
using WePay.AccountMembership.Request;
using WePay.AccountMembership.Response;

namespace WePay.AccountMembership
{
    /// <summary>
    /// Using the Account Membership APIs to add or change an account admin requires WePay permission.
    /// A user must have confirmed their account before they can be added or modified into an admin role (financial owner).
    /// When a call is changing admin, AdminContext and Reason are required.
    /// Partners must construct a user interface that asks merchants the reason for the change, so that WePay’s risk management system can process the change appropriately.
    /// Important: The admin of an account can only be changed on the condition that the account has not previously settled any funds to a bank account or via paper check.
    /// </summary>
    public class AccountMembershipService : WePayApiService<AccountMembershipService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Create = 0,
            Modify,
            Remove
        }

        /// <summary>
        /// Use this call to add a user to an account.
        /// If you want the new user to have the role set to admin, you must specify an admin_context with a reason.
        /// The WePay Risk team reviews these requests and must approve them before the new user is granted admin privileges.
        /// Note: In the AdminContext, if you specify the reason as anything other than beneficiary, you must provide an explanation.
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
        /// Use this to modify the role of a user that already has access to an account.
        /// To remove access completely, use the Remove call.
        /// The access token must be the token associated with the current admin, not the user to be modified.
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
        /// Allows a partner to remove a user from a specific account.
        /// The user being removed must not be the only current admin.
        /// CAUTION: The access token sent in the header must be that of the financial admin. The UserId is for the user to be removed.
        /// </summary>
        /// <param name="removeRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> RemoveAsync(RemoveRequest removeRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(removeRequest, EndPointUrls.Remove, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Create = "account/membership/create";
            public const string Modify = "account/membership/modify";
            public const string Remove = "account/membership/remove";
        }

        public AccountMembershipService(bool enableValidation = false,
                                        string accessToken = null,
                                        bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}