using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Checkout.Response;

namespace WePay.Checkout.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Request.FindRequest";

        /// <summary>
        /// The unique ID of the account whose checkouts you are searching.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The start position for your search.
        /// Default: 0
        /// </summary>
        public long? Start { get; set; }

        /// <summary>
        /// The maximum number of returned entries.
        /// Default: 50
        /// </summary>
        public long? Limit { get; set; }

        /// <summary>
        /// The unique ID of the checkout (set by the application in a Checkout Create call)
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The current state of the checkout.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.CheckoutStates)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Checkout.Common.CheckoutStates")]
        public string State { get; set; }

        /// <summary>
        /// The unique ID for the preapproval used to create this checkout.
        /// Note: Useful if you want to look up all the payments for a recurring preapproval (using the AutoRecur parameter).
        /// </summary>
        public long? PreapprovalId { get; set; }

        /// <summary>
        /// All checkouts after given start time, Unix timestamp (UTC)
        /// </summary>
        public long? StartTime { get; set; }

        /// <summary>
        /// All checkouts before given end time, Unix timestamp (UTC)
        /// </summary>
        public long? EndTime { get; set; }

        /// <summary>
        /// Sort the results of the search by time created.
        /// Use desc for most recent to least recent. Use asc for least recent to most recent.
        /// (Enumeration of these values can be found in WePay.Shared.Common.SortOrders)
        /// Default: desc
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.SortOrders")]
        public string SortOrder { get; set; }

        /// <summary>
        /// All checkouts that have the given shipping fee.
        /// </summary>
        public double? ShippingFee { get; set; }
    }
}