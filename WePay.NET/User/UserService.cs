using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.User.Request;
using WePayApi.User.Response;

namespace WePayApi.User
{
    /// <summary>
    /// The user object represents a single user registered on WePay.
    /// A single user may be authorized on multiple applications.
    /// Users are segmented by email address, whereas access tokens map to a specific user-application pair.
    /// </summary>
    public class UserService : WePayApiService<UserService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Modify,
            Register,
            SendConfirmation,
            RequestSsoToken,
            MarkEmailVerified,
            Logout,
            ChangeEmail
        }

        /// <summary>
        /// Registers a user with your application and returns a temporary access token for that user.
        /// The temporary access token will expire 90 days after its creation if not approved.
        /// You can send the user an email to confirm their WePay account using the User SendConfirmation call.
        /// Unconfirmed accounts created with a temporary access token have a few restrictions:
        /// They can only accept $100,000.
        /// New payments will be disabled 14 days after they accept their first payment.
        /// They will be deleted 30 days after they accept their first payment.
        /// Once an unconfirmed account created with a temporary access token is deleted, all accepted payments are refunded.
        /// You must specify the ClientId and ClientSecret for your application.
        /// This call does not use OAuth2 authorization, so you should not pass an access token.
        /// </summary>
        /// <param name="registerRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<RegisterResponse> RegisterAsync(RegisterRequest registerRequest,
                                                          string accessToken = null,
                                                          bool? useStaging = null)
        {
            return await PostRequestAsync(registerRequest, EndPointUrls.Register, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to look up details about the user associated with the access token used to make the call.
        /// There are no arguments necessary for this call.
        /// Only an access token passed in the authorization header is required.
        /// The access token must be that of the user whose information you are searching for.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LookupAsync(string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync<LookupResponse>(null, EndPointUrls.Lookup, accessToken, useStaging);
        }

        /// <summary>
        /// This call allows you to add a CallbackUri to the user object.
        /// If you add a CallbackUri you will receive IPNs with the UserId each time the user revokes their access token or the user is deleted. 
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
        /// For users who were registered via the User Regiser call, this API call must be used to send the registration confirmation email.
        /// This call can also be used later to resend the registration confirmation email as needed.
        /// The AccessToken returned by the associated User Register call must be passed in the authorization header.
        /// </summary>
        /// <param name="sendConfirmationRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> SendConfirmationAsync(SendConfirmationRequest sendConfirmationRequest,
                                                                string accessToken = null,
                                                                bool? useStaging = null)
        {
            return await PostRequestAsync(sendConfirmationRequest, EndPointUrls.SendConfirmation, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to obtain a one-time use SsoToken which must be signed within 10 minutes.
        /// There are no arguments for this call.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<RequestSsoTokenResponse> RequestSsoTokenAsync(string accessToken = null,
                                                                        bool? useStaging = null)
        {
            return await PostRequestAsync<RequestSsoTokenResponse>(null, EndPointUrls.RequestSsoToken, accessToken, useStaging);
        }

        /// <summary>
        /// For SSO users, use this call to indicate a successful verification of the user’s email address.
        /// This call may be made anytime after the User Regiser call is successfully completed,
        /// however it must be executed within the time limits specified in User Regiser for confirming accounts.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> MarkEmailVerifiedAsync(string accessToken = null,
                                                                 bool? useStaging = null)
        {
            return await PostRequestAsync<LookupResponse>(null, EndPointUrls.MarkEmailVerified, accessToken, useStaging);
        }

        /// <summary>
        /// SSO platforms use this call to force logout of any active WePay session.
        /// Typically platforms call this as part of a logout on their own server if they have initiated any SSO sessions.
        /// There are no arguments for this call.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LogoutAsync(string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync<LookupResponse>(null, EndPointUrls.Logout, accessToken, useStaging);
        }

        /// <summary>
        /// SSO platforms use this call to update a user’s email address at WePay.
        /// WePay assumes any new email address is verified.
        /// Note that WePay is unable to update user email addresses via API for non-SSO users at this time.
        /// As this is a high-security operation, WePay expects MFA to be checked before making this API call.
        /// If your platform is using WePay’s MFA service, the trust cookie must be sent.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="changeEmailRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
    public async Task<LookupResponse> ChangeEmailAsync(ChangeEmailRequest changeEmailRequest,
                                                       string accessToken = null,
                                                       bool? useStaging = null)
        {
            return await PostRequestAsync(changeEmailRequest, EndPointUrls.ChangeEmail, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "user";
            public const string Modify = "user/modify";
            public const string Register = "user/register";
            public const string SendConfirmation = "user/send_confirmation";
            public const string RequestSsoToken = "user/request_sso_token";
            public const string MarkEmailVerified = "user/mark_email_verified";
            public const string Logout = "user/logout";
            public const string ChangeEmail = "user/change_email";
        }

        public UserService(bool enableValidation = false,
                           string accessToken = null,
                           bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}