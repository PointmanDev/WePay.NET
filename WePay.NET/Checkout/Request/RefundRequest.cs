using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Checkout.Response;

namespace WePayApi.Checkout.Request
{
    public class RefundRequest : Shared.WePayRequest<StateResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Request.RefundRequest";

        /// <summary>
        /// The unique ID of the checkout to be refunded.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CheckoutId")]
        public long? CheckoutId { get; set; }

        /// <summary>
        /// The reason the payment is being refunded.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - RefundReason cannot exceed 255 characters")]
        public string RefundReason { get; set; }

        /// <summary>
        /// The total amount that will be refunded back to the payer.
        /// Note that this amount must be less than the net of the transaction.
        /// To perform a full refund, do not pass the amount parameter.
        /// </summary>
        public double? Amount { get; set; }

        /// <summary>
        /// The portion of the amount that will be refunded as an AppFee refund.
        /// For example, if amount is 100.00 and AppFee is 10.00, then the payer will receive a refund of 100.00,
        /// where 90.00 is the net refund from the payment account, and 10.00 is the AppFee refund.
        /// Note that this value must be less than the remaining balance of the app fee.
        /// </summary>
        public double? AppFee { get; set; }

        /// <summary>
        /// A short message that will be included in the payment refund email to the payer.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - PayerEmailMessage cannot exceed 65535 characters")]
        public string PayerEmailMessage { get; set; }

        /// <summary>
        /// A short message that will be included in the payment refund email to the payee.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - PayeeEmailMessage cannot exceed 65535 characters")]
        public string PayeeEmailMessage { get; set; }
    }
}