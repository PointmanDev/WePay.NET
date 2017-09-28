using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;

namespace WePay.Account.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the account you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}