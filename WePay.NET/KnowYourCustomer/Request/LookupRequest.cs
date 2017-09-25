using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.KnowYourCustomer.Response;

namespace WePayApi.KnowYourCustomer.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the account for which you are seeking KYC information.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}