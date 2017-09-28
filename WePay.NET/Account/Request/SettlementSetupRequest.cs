using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;
using WePay.Shared;
using WePay.Account.Structure;

namespace WePay.Account.Request
{
    public class SettlementSetupRequest : WePayRequest<SettlementSetupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.SettlementSetupRequest";

        /// <summary>
        /// The account ID for which an auto withdrawal is to be setup.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Settlement method containing exactly one of these:
        /// SettlementBankId as setup via SettlementBank - Create, or SendCheckToAddress which is the address to which recurring checks are sent.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public SettlementMethod SettlementMethod { get; set; }

        /// <summary>
        /// How often funds are sent.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Frequencies)
        /// Note: Daily is not allowed for SendCheckToAddress settlement method.
        /// </summary>
        [ValidateWePayValue(IsRequired = true, WePayValuesClassName = "WePay.Shared.Common.Frequencies", ErrorMessage = Identifier)]
        public string Frequency { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string errorPrefix = "Invalid " + Identifier + ", ";

            if (SettlementMethod != null)
            {
                if (SettlementMethod.SendCheckToAddress != null && Frequency == Shared.Common.Frequencies.Daily)
                {
                    return errorPrefix + "SettlementMethod using SendCheckToAddress cannot use Frequency of Daily";
                }

                return null;
            }

            return errorPrefix + "requires SettlementMethod to determine correct Frequency";
        }
    }
}