using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Order.Response;

namespace WePay.Order.Request
{
    public class LookupRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Order.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the order you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires OrderId")]
        public long? OrderId { get; set; }
    }
}