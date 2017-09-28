using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Account.Common
{
    /// <summary>
    /// All possible account review statuses
    /// </summary>
    public static class AccountReviewStatuses
    {
        /// <summary>
        /// Indices for the Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            NotRequested,
            Pending,
            ReviewOk
        }

        public const string NotRequested = "not_requested";
        public const string Pending = "pending";
        public const string ReviewOk = "review_ok";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AccountReviewStatuses()
        {
            WePayValues.FillValuesList(typeof(AccountReviewStatuses), Values);
        }
    }
}