using WePayApi.Shared;

namespace WePayApi.Withdrawal.Common
{
    /// <summary>
    /// All possible Withdrawal states
    /// </summary>
    public class WithdrawalStates : WePayValues<WithdrawalStates>
    {
        public enum Choices : int
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
    }
}