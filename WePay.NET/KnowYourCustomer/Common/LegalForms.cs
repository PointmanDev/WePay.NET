using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Common
{
    /// <summary>
    /// All possible Legal Forms currently recognized by WePay
    /// </summary>
    public class LegalForms : WePayValues<LegalForms>
    {
        public enum Choices : int
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
    }
}