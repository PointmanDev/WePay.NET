using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;
using WePayApi.CreditCard.Response;
using WePayApi.Shared.Common;

namespace WePayApi.CreditCard.Request
{
    public class CreateRequest : Shared.WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Request.CreateRequest";

        /// <summary>
        /// The ID for your API application. You can find it on your app dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The number on the credit card.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires CcNumber"),
         StringLength(255, ErrorMessage = Identifier + " - CcNumber cannot exceed 255 characters")]
        public string CcNumber { get; set; }

        /// <summary>
        /// The expiration month on the credit card.
        /// Expects a number in the range of 1 - 12
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ExpirationMonth")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// The expiration year on the credit card.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ExpirationYear")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// The full name of the user that the card belongs to.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires UserName"),
         StringLength(255, ErrorMessage = Identifier + " - UserName cannot exceed 255 characters")]
        public string UserName { get; set; }

        /// <summary>
        /// Valid email address of the user the card belongs to.
        /// If the e-mail belongs to the merchant, your application's user account, or is invalid, the transaction may be canceled for risk reasons.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The billing address on the card. Only PostalCode and Country are required.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address Address { get; set; }

        /// <summary>
        /// The CVV (also known as a card security code, CVV2, or CVC) on the card.
        /// PERMISSION REQUIRED: This parameter is only optional when the app has the correct permissions.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Cvv cannot exceed 255 characters")]
        public string Cvv { get; set; }

        /// <summary>
        /// The IP address of the user to whom this card belongs.
        /// This should be sent if you are not using WePay's Javascript library.
        /// </summary>
        [StringLength(16, ErrorMessage = Identifier + "- OriginalIp cannot exceed 16 characters")]
        public string OriginalIp { get; set; }

        /// <summary>
        /// The user-agent (for web) or the IMEI (for mobile) of the user to whom his card belongs.
        /// This should be sent if you are not using WePay's Javascript library.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - OriginalDevice cannot exceed 255 characters")]
        public string OriginalDevice { get; set; }

        /// <summary>
        /// The unique reference ID of the CreditCard.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

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

        /// <summary>
        /// This is set if the merchant has manually entered the credit card number.
        /// (Enumeration of these values can be found in WePayApi.CreditCard.Common.VirtualTerminalModes)
        /// PERMISSION REQUIRED
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.CreditCard.Common.VirtualTerminalModes")]
        public string VirtualTerminal { get; set; }

        /// <summary>
        /// This is set if the credit card was obtained using the W3C Payment Request API.
        /// </summary>
        public bool? PaymentRequestFlag { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string error = "";

            if (AutoUpdate != null && AutoUpdate.Value && (CallbackUri == null || CallbackUri == ""))
            {
                error += " setting AutoUpdate to true requires a CallbackUri.";
            }

            if (Address != null)
            {
                if (Countries.Values.IndexOf(Address.Country) == -1)
                {
                    error += " Address requires Country.";
                }
            }

            return error == "" ? null : ("Invalid " + Identifier + ", " + error);
        }
    }
}