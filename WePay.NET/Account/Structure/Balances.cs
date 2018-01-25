using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Account.Structure
{
    /// <summary>
    /// The balances structure contains information on the account balances and automated withdrawals.
    /// Accounts can have multiple balances (one for each currency they support).
    /// </summary>
    public class Balances
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Structure.Balances";

        /// <summary>
        /// The ISO 4217 currency code.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// The available balance for this account (specific to the currency specified).
        /// </summary>
        public double? Balance { get; set; }

        /// <summary>
        /// The amount of money that being sent to the account that is still pending.
        /// </summary>
        public double? IncomingPendingAmount { get; set; }

        /// <summary>
        /// The amount of money being settled to the merchant (either via check or ACH) that is still pending.
        /// </summary>
        public double? OutgoingPendingAmount { get; set; }

        /// <summary>
        /// The amount of money held in reserves.
        /// </summary>
        public double? ReservedAmount { get; set; }

        /// <summary>
        /// The amount of money disputed either via chargeback or through WePay.
        /// </summary>
        public double? DisputedAmount { get; set; }

        /// <summary>
        /// How the money will be settled to the merchant.
        /// (Enumeration of these values can be found in WePay.Shared.Common.SettlementPaymentMethods)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.SettlementPaymentMethods")]
        public string WthdrawlType { get; set; }

        /// <summary>
        /// (Enumeration of these values can be found in WePay.Shared.Common.Frequencies )
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Frequencies")]
        public string WithdrawalPeriod { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) for the next scheduled settlement.
        /// </summary>
        public long? WithdrawalNextTime { get; set; }

        /// <summary>
        /// The masked name of the entity funds will be settled to.
        /// If a check is being sent, this will be the name of the entity the check was mailed to (the "pay to the order of" field).
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - WithdrawalBankName cannot exceed 6 characters")]
        public string WithdrawalBankName { get; set; }
    }
}