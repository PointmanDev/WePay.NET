using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.CreditCard.Response;

namespace WePay.CreditCard.Request
{
    public class DeleteRequest : Shared.WePayRequest<StateResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.CreditCard.Request.DeleteRequest";

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
        /// The unique ID of the credit card you want to delete.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CreditCardId")]
        public long? CreditCardId { get; set; }
    }
}