using Newtonsoft.Json;
using WePayApi.Shared;

namespace WePayApi.Account.Structure
{
    /// <summary>
    /// The account currency status structure contains information about an account’s ability to process
    /// incoming and outgoing payments for a particular currency.
    /// </summary>
    public class AccountCurrencyStatus
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Structure.AccountCurrencyStatus";

        /// <summary>
        /// The ISO 4217 currency code.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// Ability to process incoming payments for this currency.
        /// (Enumeration of these values can be found in WePayApi.Account.Common.PaymentsStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Account.Common.PaymentsStatuses")]
        public string IncomingPaymentsStatus { get; set; }

        /// <summary>
        /// Ability to process outgoing payments for this currency.
        /// (Enumeration of these values can be found in WePayApi.Account.Common.PaymentsStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Account.Common.PaymentsStatuses")]
        public string OutgoingPaymentsStatus { get; set; }

        /// <summary>
        /// Review status of an account for this currency.
        /// (Enumeration of these values can be found in WePayApi.Account.Common.AccountReviewStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Account.Common.AccountReviewStatuses")]
        public string AccountReviewStatus { get; set; }
    }
}