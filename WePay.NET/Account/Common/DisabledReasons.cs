using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Account.Common
{
    /// <summary>
    /// All reasons for why an account was disabled
    /// </summary>
    public static class DisabledReasons
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Fraud,
            HighRiskChargeback,
            ReportedUser,
            TosViolation,
            CountryNotSupported,
            ClosedForLoss,
            NoSettlementPath
        }

        /// <summary>
        /// WePay has determined that fraudulent activity is occuring and is perpetrated by the account administrator (not a fraudulent transaction by a payer), or the account is being administered for fraudulent purposes. The account can be reinstated if an appeal has been made and the subsequent investigation reveals that any fraud found is not a result of fraudulent activities on the part of the account owner or administrator.
        /// </summary>
        public const string Fraud = "fraud";

        /// <summary>
        /// Based on an account history of excessive chargeback activity or a determination by WePay that the type of business is at high risk of excessive chargebacks. There is no remediation for this type of disablement.
        /// </summary>
        public const string HighRiskChargeback = "high_risk_chargeback";

        /// <summary>
        /// The platform has reported that they closed the merchant account. The account administrator must resolve issues with the platform before WePay can reinstate the account.
        /// </summary>
        public const string ReportedUser = "reported_user";

        /// <summary>
        /// Occurs when the TOS agreement has been violated by the merchant. See our Terms of Service (https://go.wepay.com/terms-of-service-us), section 7 for more information.
        /// </summary>
        public const string TosViolation = "tos_violation";

        /// <summary>
        /// Occurs when the merchant is not operating in one of WePay's supported countries or is accepting payment in a currency other than that of the country where they are registered.
        /// </summary>
        public const string CountryNotSupported = "country_not_supported";

        /// <summary>
        ///  Occurs when the account balance becomes negative and remains so for a period of 30 days. Remediation of this state is on a case-by-case basis following review by the WePay Risk Team.
        /// </summary>
        public const string ClosedForLoss = "closed_for_loss";

        /// <summary>
        /// Occurs when more than 30 days have elapsed after the merchant accepts their first payment and no settlement path has been established. This is remediated by adding a settlement method (e.g., a bank account) and completing the KYC process.
        /// </summary>
        public const string NoSettlementPath = "no_settlement_path";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static DisabledReasons()
        {
            WePayValues.FillValuesList(typeof(DisabledReasons), Values);
        }
    }
}