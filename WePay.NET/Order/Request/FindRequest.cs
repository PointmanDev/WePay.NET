using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Order.Response;

namespace WePayApi.Order.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Order.Request.FindRequest";

        /// <summary>
        /// The unique ID of the order you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires OrderId")]
        public long? OrderId { get; set; }

        /// <summary>
        /// Starting point for looking up existing orders.
        /// Default: 0
        /// </summary>
        public long? Start { get; set; }

        /// <summary>
        /// Ending point for looking up existing orders.
        /// Default: 50
        /// </summary>
        public long? Limit { get; set; }
    }
}