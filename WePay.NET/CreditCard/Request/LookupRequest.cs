using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.CreditCard.Response;

namespace WePay.CreditCard.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.CreditCard.Request.LookupRequest";

        /// <summary>
        /// The ID for your API application. You can find it on your application's dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application. You can find it on your application's dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The unique ID of the credit card you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CreditCardId")]
        public long? CreditCardId { get; set; }
    }
}