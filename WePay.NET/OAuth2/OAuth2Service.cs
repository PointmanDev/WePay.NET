using System.Threading.Tasks;
using WePay.Shared;
using WePay.OAuth2.Request;
using WePay.OAuth2.Response;

namespace WePay.OAuth2
{
    /// <summary>
    /// Create users using the OAuth2 API calls.
    /// </summary>
    public class OAuth2Service : WePayApiService<OAuth2Service.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Authorize,
            Token
        }

        /// <summary>
        /// This call is a URI which your application sends to the user so that they can grant your application permission to make API calls on their behalf.
        /// </summary>
        /// <param name="authorizeRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<AuthorizeResponse> AuthorizeAsync(AuthorizeRequest authorizeRequest,
                                                            string accessToken = null,
                                                            bool? useStaging = null)
        {
            return await PostRequestAsync(authorizeRequest, EndPointUrls.Authorize, accessToken, useStaging);
        }

        /// <summary>
        /// Once you have sent the user through the authorization endpoint and they have returned with a code,
        /// you can use that code to retrieve an access token for that user.
        /// The redirect URI will need to be the same as in the in OAuth2 Token step.
        /// Note that when you request a new access token with this call,
        /// WePay automatically revokes all previously issued access tokens for this user.
        /// Make sure you update the access token you are using for a user each time you make this call.
        /// </summary>
        /// <param name="tokenRequest"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<TokenResponse> TokenAsync(TokenRequest tokenRequest,
                                                    string accessToken = null,
                                                    bool? useStaging = null)
        {
            return await PostRequestAsync(tokenRequest, EndPointUrls.Token, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Authorize = "oauth2/authorize";
            public const string Token = "oauth2/token";
        }

        public OAuth2Service(bool enableValidation = false,
                             string accessToken = null,
                             bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}