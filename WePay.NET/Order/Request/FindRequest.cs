using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Order.Response;

namespace WePay.Order.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Order.Request.FindRequest";

        /// <summary>
        /// The AccountId of the order you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

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