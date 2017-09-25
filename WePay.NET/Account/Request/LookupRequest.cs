using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Account.Response;

namespace WePayApi.Account.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the account you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}