using WePayApi.Shared;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Risk.Response;

namespace WePayApi.Risk.Request
{
    public class LookupRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the rbit you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires RbitId")]
        public long? RbitId { get; set; }
    }
}