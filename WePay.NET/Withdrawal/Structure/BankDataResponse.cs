namespace WePayApi.Withdrawal.Structure
{
    /// <summary>
    /// The bank data structure contains information about the bank account for a withdrawal.
    /// </summary>
    public class BankDataResponse
    {
        /// <summary>
        /// Nickname of the bank.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Last four digits of the bank account.
        /// </summary>
        public string AccountLastFour { get; set; }

        /// <summary>
        /// A short description of the reason for the withdrawal.
        /// </summary>
        public string Note { get; set; }
    }
}