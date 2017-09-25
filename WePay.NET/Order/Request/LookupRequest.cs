using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Order.Response;

namespace WePayApi.Order.Request
{
    public class LookupRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Order.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the order you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires OrderId")]
        public long? OrderId { get; set; }
    }
}