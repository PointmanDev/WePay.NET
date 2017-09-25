using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;
using WePayApi.CreditCard.Response;

namespace WePayApi.CreditCard.Request
{
    public class EnableRecurringRequest : Shared.WePayRequest<SimpleResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Request.EnableRecurringRequest";

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
        /// The unique ID of the credit card.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CreditCardId")]
        public long? CreditCardId { get; set; }

        /// <summary>
        /// The billing address on the card.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address Address { get; set; }
    }
}