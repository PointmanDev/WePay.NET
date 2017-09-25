using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Checkout.Response;

namespace WePayApi.Checkout.Request
{
    public class CancelRequest : Shared.WePayRequest<StateResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Request.CancelRequest";

        /// <summary>
        /// The unique ID of the checkout to be canceled.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CheckoutId")]
        public long? CheckoutId { get; set; }

        /// <summary>
        /// The reason the payment is being cancelled.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires CancelReason"),
         StringLength(255, ErrorMessage = Identifier + " - CancelReason cannot exceed 255 characters")]
        public string CancelReason { get; set; }
    }
}