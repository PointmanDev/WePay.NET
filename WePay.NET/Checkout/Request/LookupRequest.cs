using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Checkout.Response;

namespace WePay.Checkout.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the checkout you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CheckoutId")]
        public long? CheckoutId { get; set; }
    }
}