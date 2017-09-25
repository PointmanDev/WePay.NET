using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Withdrawal.Response;

namespace WePayApi.Withdrawal.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Withdrawal.Request.FindRequest";

        /// <summary>
        /// A unique ID for the account for which you want to find withdrawals.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The maximum number of withdrawals to be returned.
        /// Default: 50
        /// </summary>
        public long? Limit { get; set; }

        /// <summary>
        /// Where to start in the withdrawal list if more than the specified limit of withdrawals are found.
        /// </summary>
        public long? Start { get; set; }

        /// <summary>
        /// Sort the results of the search by time created. Use desc for most recent to oldest.
        /// Use asc for oldest to most recent.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.SortOrders)
        /// Default: desc
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// Filter by a withdrawal state.
        /// (Enumeration of these values can be found in WePayApi.Withdrawal.Common.WithdrawalStates)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Withdrawal.Common.WithdrawalStates")]
        public string State { get; set; }
    }
}