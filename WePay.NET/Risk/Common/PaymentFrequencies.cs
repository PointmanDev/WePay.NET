using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    public class PaymentFrequencies : WePayValues<PaymentFrequencies>
    {
        public enum Indices : int
        {
            Weekly,
            Monthly,
            Quarterly,
            Annually
        }

        public const string Weekly = "weekly";
        public const string Monthly = "monthly";
        public const string Quarterly = "quarterly";
        public const string Annually = "annually";
    }
}