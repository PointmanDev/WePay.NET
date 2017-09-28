using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.PaymentBank.Response;

namespace WePay.PaymentBank.Request
{
    public class LookupRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.PaymentBank.Request.LookupRequest";

        /// <summary>
        /// The unique ID for the payment bank you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires PaymentBankId")]
        public long? PaymentBankId { get; set; }

        /// <summary>
        /// The ID for your API application.
        /// You can find it on your application's dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application.
        /// You can find it on your application's dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }
    }
}