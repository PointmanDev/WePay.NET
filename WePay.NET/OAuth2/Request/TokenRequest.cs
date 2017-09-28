using WePay.Shared;
using WePay.OAuth2.Response;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.OAuth2.Request
{
    public class TokenRequest : WePayRequest<TokenResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.OAuth2.Request.TokenRequest";

        /// <summary>
        /// The client id issued to the app, found on your application's dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The URI the user will be redirected to after authorization. Must have the same domain as the application.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires RedirectUri"),
         StringLength(2083, ErrorMessage = Identifier + " - RedirectUri cannot exceed 2083 characters")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The client secret issued to the app by WePay, found on your application's dashboard
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The code returned by OAuth2 Authorize.
        /// This code expires in 10 minutes.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Code"),
         StringLength(255, ErrorMessage = Identifier + " - Code cannot exceed 255 characters")]
        public string Code { get; set; }

        /// <summary>
        /// A callback_uri you want to receive IPNs for this user on.
        /// If you specify a callback URI you will receive IPNs with the UserId when the user revokes an AccessToken or is deleted.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CallbackUri"),
         StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set;  }
    }
}