using Newtonsoft.Json;
using WePay.Shared;

namespace WePay.Account.Structure
{
    /// <summary>
    /// The account currency status structure contains information about an account’s ability to process
    /// incoming and outgoing payments for a particular currency.
    /// </summary>
    public class AccountCurrencyStatus
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Structure.AccountCurrencyStatus";

        /// <summary>
        /// The ISO 4217 currency code.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// Ability to process incoming payments for this currency.
        /// (Enumeration of these values can be found in WePay.Account.Common.PaymentsStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Account.Common.PaymentsStatuses")]
        public string IncomingPaymentsStatus { get; set; }

        /// <summary>
        /// Ability to process outgoing payments for this currency.
        /// (Enumeration of these values can be found in WePay.Account.Common.PaymentsStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Account.Common.PaymentsStatuses")]
        public string OutgoingPaymentsStatus { get; set; }

        /// <summary>
        /// Review status of an account for this currency.
        /// (Enumeration of these values can be found in WePay.Account.Common.AccountReviewStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Account.Common.AccountReviewStatuses")]
        public string AccountReviewStatus { get; set; }
    }
}