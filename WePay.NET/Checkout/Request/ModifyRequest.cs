using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Checkout.Response;

namespace WePay.Checkout.Request
{
    public class ModifyRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Request.ModifyRequest";

        /// <summary>
        /// The unique ID of the checkout you want to modify.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CheckoutId")]
        public long? CheckoutId { get; set; }

        /// <summary>
        /// The URI that will receive any instant payment notifications sent.
        /// Needs to be a full URI (ex https://www.example.com ) and must not be localhost or 127.0.0.1 or include wepay.com.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }
    }
}