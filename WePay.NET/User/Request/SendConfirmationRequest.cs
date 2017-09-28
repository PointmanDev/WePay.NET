using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.User.Response;

namespace WePay.User.Request
{
    public class SendConfirmationRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.User.Request.SendConfirmationRequest";

        /// <summary>
        /// A short message that will be included in the email to the user.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - EmailMessage cannot exceed 65535 characters")]
        public string EmailMessage { get; set; }

        /// <summary>
        /// The subject line of the email.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - EmailSubject cannot exceed 255 characters")]
        public string EmailSubject { get; set; }

        /// <summary>
        /// The text on the button in the confirmation email.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - EmailButtonText cannot exceed 255 characters")]
        public string EmailButtonText { get; set; }
    }
}