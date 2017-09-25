using WePayApi.Shared;

namespace WePayApi.OAuth2.Response
{
    public class AuthorizeResponse : WePayResponse
    {
        /// <summary>
        /// The authorization code used to get the access token. This code expires in 10 minutes.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The opaque value the client application uses to maintain state (same as above, if provided).
        /// </summary>
        public string State { get; set; }
    }
}