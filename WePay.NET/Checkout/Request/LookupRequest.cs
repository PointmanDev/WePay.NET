using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Checkout.Response;

namespace WePayApi.Checkout.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the checkout you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CheckoutId")]
        public long? CheckoutId { get; set; }
    }
}