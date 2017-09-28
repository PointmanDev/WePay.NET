using System.Collections.Generic;
using WePay.Shared;

namespace WePay.KnowYourCustomer.Common
{
    /// <summary>
    /// All possible Legal Forms currently recognized by WePay
    /// </summary>
    public static class LegalForms
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            SoleTrader = 0,
            Partnership,
            PrivateLimitedCompany,
            PublicLimitedCompany,
            LimitedLiabilityPartnership,
            Charity
        }

        public const string SoleTrader = "sole_trader";
        public const string Partnership = "partnership";
        public const string PrivateLimitedCompany = "private_limited_company";
        public const string PublicLimitedCompany = "public_limited_company";
        public const string LimitedLiabilityPartnership = "limited_liability_partnership";
        public const string Charity = "charity";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static LegalForms()
        {
            WePayValues.FillValuesList(typeof(LegalForms), Values);
        }
    }
}