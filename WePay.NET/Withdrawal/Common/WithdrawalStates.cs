using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Withdrawal.Common
{
    /// <summary>
    /// All possible Withdrawal states
    /// </summary>
    public static class WithdrawalStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Started,
            Captured,
            Failed
        }

        /// <summary>
        /// The withdrawal has started processing.
        /// </summary>
        public const string Started = "started";

        /// <summary>
        /// The withdrawal has been credited to the payee's bank account.
        /// </summary>
        public const string Captured = "captured";

        /// <summary>
        /// The withdrawal has failed.
        /// </summary>
        public const string Failed = "failed";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static WithdrawalStates()
        {
            WePayValues.FillValuesList(typeof(WithdrawalStates), Values);
        }
    }
}