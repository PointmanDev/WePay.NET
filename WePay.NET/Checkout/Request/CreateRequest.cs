using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Checkout.Response;
using WePay.Shared;
using WePay.Checkout.Structure;
using WePay.Risk.Structure.Rbit;

namespace WePay.Checkout.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Request.CreateRequest";

        /// <summary>
        /// The unique ID of the account for which you want to create a checkout.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// A short description of what is being paid for.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ShortDescription"),
         StringLength(255, ErrorMessage = Identifier + " - ShortDescription cannot exceed 255 characters")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The checkout type.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.CheckoutTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, IsRequired = true, WePayValuesClassName = "WePay.Checkout.Common.CheckoutTypes")]
        public string Type { get; set; }

        /// <summary>
        /// The nominal amount of the transaction (not including any processing fees or application fees).
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The currency used.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// A more detailed description of the purchased goods or services.
        /// </summary>
        [StringLength(2047, ErrorMessage = Identifier + " - LongDescription cannot exceed 2047 characters")]
        public string LongDescription { get; set; }

        /// <summary>
        /// Specifies a short message to send to the payee and payer when a checkout is successful.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public EmailMessage EmailMessage { get; set; }

        /// <summary>
        /// Specifies whether an app fee will be collected and who should pay the app fee.
        /// Note that for EMV (chip type cards) transactions, this parameter must be present.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Fee Fee { get; set; }

        /// <summary>
        /// The URI that will receive any instant payment notifications sent.
        /// Needs to be a full URI (e.g., https://www.example.com ) and must not be localhost or 127.0.0.1, nor may it include wepay.com.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }

        /// <summary>
        /// If set to false then the payment will not automatically be released to the account and will be held by WePay in payment state captured.
        /// To release funds to the account you must make a Release call.
        /// If you do not release the funds within 14 days, then the payment will be automatically cancelled or refunded.
        /// Default: true
        /// PERMISSION REQUIRED
        /// </summary>
        public bool? AutoRelease { get; set; }

        /// <summary>
        /// Partner supplied reference ID for this checkout.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Customer-generated unique ID. WePay will only process a single call with a given UniqueId. Platforms can use this to prevent duplicates ( e.g., when retrying if a call times out).
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - UniqueId cannot exceed 255 characters")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Use this to have payers enter payment information on a WePay hosted checkout URL.
        /// Send either HostedCheckout or PaymentMethod parameter.
        /// Do not send both parameters at the same time.
        /// Default: HostedCheckout
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public HostedCheckout HostedCheckout { get; set; }

        /// <summary>
        /// Use this to pay with information your platform acquired through CreditCard or PaymentBank calls.
        /// Send either HostedCheckout or PaymentMethod parameter.
        /// Do not send both parameters at the same time.
        /// Default: HostedCheckout
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Delivery type for checkout.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.DeliveryTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Checkout.Common.DeliveryTypes")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// Risk information related to payer.
        /// Expects
        /// 1) AddressRbit (Service Address)
        /// 2) PhoneRbit
        /// 3) EmailRbit
        /// 4) PersonRbit
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Rbit[] PayerRbits { get; set; }

        /// <summary>
        /// Risk information related to transaction
        /// Expects
        /// 1) TransactionRbit
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Rbit[] TransactionRbits { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string errorPrefix = "Invalid " + Identifier + ", ";

            if (HostedCheckout == null && PaymentMethod == null)
            {
                return errorPrefix + "requires HostedCheckout or PaymentMethod";
            }

            if (HostedCheckout != null && PaymentMethod != null)
            {
                return errorPrefix + "only one of HostedCheckout or PaymentMethod can be non-null";
            }

            return null;
        }
    }
}