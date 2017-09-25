namespace WePayApi.Withdrawal.Structure
{
    /// <summary>
    /// The withdrawal data structure contains information about a withdrawal.
    /// </summary>
    public class WithdrawalDataResponse
    {
        /// <summary>
        /// The Unix time when the withdrawal was created.
        /// </summary>
        public long? CreateTime { get; set; }

        /// <summary>
        /// The Unix time when the withdrawal was captured and credited to the payee's bank account.
        /// Returns 0 if withdrawal is not yet captured.
        /// </summary>
        public long? CaptureTime { get; set; }

        /// <summary>
        /// The URI that the account owner will return to after completing the withdrawal.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// The URI that we will post notifications to each time the state on this withdrawal changes.
        /// </summary>
        public string CallbackUri { get; set; }

        /// <summary>
        /// The URI that you will send the account owner to to complete the withdrawal.
        /// Do not store the returned URI on your side as it can change.
        /// </summary>
        public string WithdrawalUri { get; set; }
    }
}