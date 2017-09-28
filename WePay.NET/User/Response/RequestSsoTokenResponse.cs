using WePay.Shared;

namespace WePay.User.Response
{
    public class RequestSsoTokenResponse : WePayResponse
    {
        /// <summary>
        /// A 128-bit Universally Unique Identifier (UUID).
        /// The token is a one-time use only and expires after 10 minutes.
        /// </summary>
        public string SsoToken { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) at which the SsoToken will expire.
        /// The time to live (TTL) defaults to 10 minutes.
        /// </summary>
        public long? ExpireTime { get; set; }
    }
}