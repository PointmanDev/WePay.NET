using Newtonsoft.Json;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class AutoBillingProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.AutoBillingProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.AutoBilling;
            }
        }

        /// <summary>
        /// Unix timestamp when auto-bill was first set up or last updated by the user.
        /// </summary>
        public long? AutobillSetupTime { get; set; }

        /// <summary>
        /// If this is the first payment of the auto-billing, PaymentNumber should be set to 1.
        /// If the second, PaymentNumber should be set to 2, etc.
        /// </summary>
        public long? PaymentNumber { get; set; }

        /// <summary>
        /// The number of payments that are scheduled to be auto-billed.
        /// For example, if a payer is paying for an item over three installments,
        /// TotalPaymentsScheduled should be set to 3.
        /// If there is no scheduled end to the auto-billed payments, do not include this parameter.
        /// </summary>
        public long? TotalPaymentsScheduled { get; set; }

        /// <summary>
        /// How often they should be billed.
        /// (Enumeration of these values can be found in WePay.Risk.Common.PaymentFrequencies)
        /// Note: Alternatively you may specify the number of days/weeks/months/years as follows,
        /// n(d/w/m/y) where n is a positive integer. E.g. 4d is 4 days, 5m is 5 months etc.
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.PaymentFrequencies", RegularExpression = @"^(([1-9]|[1-9][0-9]|[1-2][0-9][0-9]|3[0-5][0-9]|36[0-5])d)|(([1-9]|[1-4][0-9]|5[0-2])w)|(([1-9]|1[0-2])m)|([1-9]y)$")]
        public string PaymentFrequency { get; set; }

        /// <summary>
        /// Who set-up the auto-billing
        /// (Enumeration of these values can be found in WePay.Risk.Common.AutoBillingCreators)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.AutoBillingCreators")]
        public string SetupBy { get; set; }
    }
}