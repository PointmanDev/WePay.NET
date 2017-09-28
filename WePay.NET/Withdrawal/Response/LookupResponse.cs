using WePay.Withdrawal.Structure;

namespace WePay.Withdrawal.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the withdrawal.
        /// </summary>
        public long? WithdrawalId { get; set; }

        /// <summary>
        /// The unique ID of the account from which the funds are coming.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The state that the withdrawal is in.
        /// (Enumeration of these values can be found in WePay.Withdrawal.Common.WithdrawalStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The amount of money withdrawn from the WePay account and deposited into the bank account.
        /// </summary>
        public double? Amount { get; set; }

        /// <summary>
        /// The currency of the transaction.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The type of withdrawal.
        /// (Enumeration of these values can be found in WePay.Shared.Common.SettlementPaymentMethods)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Information about the bank to the funds are sent if the type of withdrawal was ach.
        /// Includes the nickname of the bank, the last four digits of the account, and a short note.
        /// </summary>
        public BankDataResponse BankData { get; set; }

        /// <summary>
        /// Information about the recipient if the withdrawal type was check.
        /// </summary>
        public CheckDataResponse CheckData { get; set; }

        /// <summary>
        /// Information about a withdrawal.
        /// </summary>
        public WithdrawalDataResponse WithdrawalData { get; set; }

        /// <summary>
        /// Indicates if the withdrawal is in review prior to capture.
        /// </summary>
        public bool? InReview { get; set; }
    }
}