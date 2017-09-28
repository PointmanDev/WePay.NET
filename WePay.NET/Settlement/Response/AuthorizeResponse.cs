namespace WePay.Settlement.Response
{
    public class AuthorizeResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID for the merchant's settlement bank.
        /// </summary>
        public long? SettlementBankId { get; set; }

        /// <summary>
        /// The name of the merchant's bank.
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the merchant's bank account number.
        /// </summary>
        public string AccountLastFour { get; set; }
    }
}