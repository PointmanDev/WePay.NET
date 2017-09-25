using WePayApi.Shared;

namespace WePayApi.OAuth2.Response
{
    public class TokenResponse : WePayResponse
    {
        /// <summary>
        /// The unique user ID of the user.
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// The AccessToken that you can use to make calls on behalf of the user.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// The token type.
        /// Currently only BEARER is supported.
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// How much time in seconds till the AccessToken expires.
        /// If null or not present, the access token will be valid until the user revokes it.
        /// </summary>
        public long? ExpiresIn { get; set; }
    }
}