using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Account.Structure
{
    /// <summary>
    /// Contains information about the bank to which funds are sent after withdrawal from a merchant’s account.
    /// One of SettlementBankId or SendCheckToAddress must be set.
    /// </summary>
    public class SettlementMethod : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Structure.SettlementMethod";

        /// <summary>
        /// Primary settlement bank ID for auto withdrawal.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires SettlementBankId")]
        public long? SettlementBankId { get; set; }

        /// <summary>
        /// Address information about where to send a check for auto withdrawal.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public SendCheckToAddress SendCheckToAddress { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string errorPrefix = "Invalid " + Identifier + ", ";

            if (SendCheckToAddress == null && SettlementBankId == null)
            {
                return errorPrefix + " requires SendCheckToAddress or SettlementBankId";
            }

            if (SendCheckToAddress != null && SettlementBankId != null)
            {
                return errorPrefix + " only one of SendCheckToAddress or SettlementBankId can be non-null";
            }

            return null;
        }
    }
}