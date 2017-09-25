using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.User.Response;

namespace WePayApi.User.Request
{
    public class RegisterRequest : WePayRequest<RegisterResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.User.Request.RegisterRequest";

        /// <summary>
        /// The integer client ID issued to the app, found on your application's dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The string client secret issued to the app, found on your application's dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The email of the user you want to register.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// Custom user permission settings are no longer supported.
        /// Please provide a comma-separated list of all Scopes (permissions)
        /// (Enumeration of these values can be found in WePayApi.User.Common.Scopes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.User.Common.Scopes", IsCommaSeparated = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The first name of the user you want to register.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires FirstName"),
         StringLength(127, ErrorMessage = Identifier + " - FirstName cannot exceed 127 characters")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user you want to register.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires LastName"),
         StringLength(127, ErrorMessage = Identifier + "- LastName cannot exceed 127 characters")]
        public string LastName { get; set; }

        /// <summary>
        /// The IP address of the user you want to register.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires OriginalIp"),
         StringLength(16, ErrorMessage = Identifier + " - OriginalIp cannot exceed 16 characters")]
        public string OriginalIp { get; set; }

        /// <summary>
        /// The user-agent (for web) or the IMEI (for mobile) of the user you want to register.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires OriginalDevice"),
         StringLength(255, ErrorMessage = Identifier + " - OriginalDevice cannot exceed 255 characters")]
        public string OriginalDevice { get; set; }

        /// <summary>
        /// A Unix timestamp (UTC) referencing the time the user accepted WePay's terms of service.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires TosAcceptanceTime")]
        public long? TosAcceptanceTime { get; set; }

        /// <summary>
        /// The URI the user will be redirected to after they have confirmed they wanted to be registered on WePay.
        /// By default this will be your application's homepage.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - RedirectUri cannot exceed 2083 characters")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The callback URI where you want to receive IPNs.
        /// Must be a full URI.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }

        /// <summary>
        /// The type of user to be created.
        /// This parameter is used to create SSO users.
        /// To create an SSO user, set the value to Sso. 
        /// Otherwise do not include this parameter in the call.
        /// (Enumeration of these values can be found in WePayApi.User.Common.UserTypes)
        /// PERMISSION REQUIRED
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.User.Common.UserTypes")]
        public string Type { get; set; }
    }
}