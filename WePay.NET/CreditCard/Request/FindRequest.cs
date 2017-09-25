using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.CreditCard.Response;

namespace WePayApi.CreditCard.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Request.FindRequest";

        /// <summary>
        /// The ID for your API application. You can find it on your app dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application. You can find it on your app dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = "WePayApi.CreditCard.FindRequest - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The reference ID of the credit card you want to find.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The maximum number of results you want returned.
        /// Default: 50
        /// </summary>
        public long? Limit { get; set; }

        /// <summary>
        /// The start position for your search.
        /// Default: 0
        /// </summary>
        public long? Start { get; set; }

        /// <summary>
        /// Sort the results of the search by time created. Use desc for most recent to least recent
        /// Use asc for least recent to most recent.
        /// Default: desc
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.SortOrders")]
        public string SortOrder { get; set; }
    }
}