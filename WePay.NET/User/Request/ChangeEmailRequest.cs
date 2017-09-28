using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.User.Response;

namespace WePay.User.Request
{
    public class ChangeEmailRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.User.Request.ChangeEmailRequest";

        /// <summary>
        /// The new email address of this user.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = "WePay.User.ChangeEmailRequest - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The MFA trust cookie - required if using WePay's MFA service.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Cookie cannot exceed 255 characters")]
        public string Cookie { get; set; }
    }
}