using WePay.Shared;

namespace WePay.User.Response
{
    public class RegisterResponse : WePayResponse
    {
        /// <summary>
        /// The unique integer user ID of the user.
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// The string access token that you can use to make calls on behalf of the user.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// The token type.
        /// Only BEARER is currently supported.
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// How much time till the access_token expires in seconds.
        /// If null or not present, the access token will be valid until the user revokes the AccessToken.
        /// </summary>
        public long? ExpiresIn { get; set; }
    }
}