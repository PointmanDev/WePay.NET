namespace WePay.Account.Response
{
    public class DeleteResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the account that was successfully deleted.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The state of the account.
        /// (Enumeration of these values can be found in WePay.Account.Common.AccountStates)
        /// </summary>
        public string State { get; set; }
    }
}