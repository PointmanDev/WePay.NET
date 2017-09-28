using WePay.Shared;

namespace WePay.PaymentBank.Response
{
    public class LookupResponse : WePayResponse
    {
        /// <summary>
        /// The unique ID for the payment bank.
        /// </summary>
        public long? PaymentBankId { get; set; }

        /// <summary>
        /// The name of the payment bank account.
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the payment bank account.
        /// </summary>
        public string AccountLastFour { get; set; }

        /// <summary>
        /// The state that the payment bank is in.
        /// </summary>
        public string State { get; set; }
    }
}