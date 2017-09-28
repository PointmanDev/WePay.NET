using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.CreditCard.Response;
using WePay.Shared;

namespace WePay.CreditCard
{
    public class ModifyRequest : Shared.WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.CreditCard.Request.ModifyRequest";

        /// <summary>
        /// The ID for your API application.
        /// You can find it on your app dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application.
        /// You can find it on your app dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The unique ID of the credit card you want to modify.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CreditCardId")]
        public long? CreditCardId { get; set; }

        /// <summary>
        /// Automatically update credit cards that have been stored with WePay.
        /// If a card is expired, or has been replaced (e.g., due to theft), it will be automatically updated based in information provided by card networks.
        /// To receive these updates, be sure to set a CallbackUri.
        /// PERMISSION REQUIRED
        /// </summary>
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// The URI that will receive IPNs for this credit card.
        /// You will receive an IPN whenever the card information is updated.
        /// REQUIRED IF AutoUpdate is true
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (AutoUpdate != null && AutoUpdate.Value && (CallbackUri == null || CallbackUri == ""))
            {
                return "Invalid " + Identifier + ", " + " setting AutoUpdate to true requires a CallbackUri.";
            }

            return null;
        }
    }
}