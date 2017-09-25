using WePayApi.Shared;
using WePayApi.OAuth2.Response;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.OAuth2.Request
{
    public class AuthorizeRequest : WePayRequest<AuthorizeResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.OAuth2.Request.AuthorizeRequest";

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
        /// Custom user permission settings are no longer supported. Please provide a comma-separated list.
        /// (Enumeration of these values can be found in WePayApi.User.Common.Scopes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.User.Common.Scopes", IsCommaSeparated = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The opaque value the client application uses to maintain state.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - State cannot exceed 2083 characters")]
        public string State { get; set; }

        /// <summary>
        /// The user name used to pre-fill the authorization form.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - UserName cannot exceed 255 characters")]
        public string UserName { get; set; }

        /// <summary>
        /// The user email used to pre-fill the authorization form.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - UserEmail cannot exceed 255 characters")]
        public string UserEmail { get; set; }

        /// <summary>
        /// The user's country of origin 2-letter ISO code
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.Countries)
        /// Default: US
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.Countries")]
        public string UserCountry { get; set; }
    }
}