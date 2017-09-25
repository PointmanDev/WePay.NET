using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.KnowYourCustomer.Response;

namespace WePayApi.KnowYourCustomer.Request
{
    public class ModifyRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Request.ModifyRequest";

        /// <summary>
        /// The unique ID of the account you want to modify.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The array of file IDs to be reviewed by WePay.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires FileIds")]
        public int[] FileIds { get; set; }
    }
}