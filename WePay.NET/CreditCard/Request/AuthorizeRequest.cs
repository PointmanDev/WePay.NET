using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.CreditCard.Response;

namespace WePayApi.CreditCard
{
    public class AuthorizeRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Request.AuthorizeRequest";

        /// <summary>
        /// The ID for your API application. You can find it on your application dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application. You can find it on your application dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The unique ID of the credit card you want to authorize.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CreditCardId")]
        public long? CreditCardId { get; set; }

        /// <summary>
        /// The unique ID of the account that will be associated with transactions made with the credit card.
        /// If specified, the account name will be part of the soft descriptor in the payer's bank statement.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}