using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.KnowYourCustomer.Response;

namespace WePay.KnowYourCustomer.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the account for which you are seeking KYC information.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}