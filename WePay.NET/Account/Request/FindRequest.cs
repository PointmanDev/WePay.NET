using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;
using WePay.Shared;

namespace WePay.Account.Request
{
    public class FindRequest : Shared.WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.FindRequest";

        /// <summary>
        /// The name of the account for which you are searching.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The reference ID of the account for which you are searching (set by the app in in Create or Modify).
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Sort the results of the search by time created.
        /// Use desc for most recent to least recent.
        /// Use asc for least recent to most recent.
        /// (Enumeration of these values can be found in WePay.Shared.Common.SortOrders)
        /// Default: desc
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.SortOrders")]
        public string SortOrder { get; set; }
    }
}