using WePay.Shared;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Risk.Response;

namespace WePay.Risk.Request
{
    public class LookupRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the rbit you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires RbitId")]
        public long? RbitId { get; set; }
    }
}