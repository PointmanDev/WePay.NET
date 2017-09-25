using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All possible payment methods which can be accepted for a check out
    /// </summary>
    public class FundingSources : WePayValues<FundingSources>
    {
        public enum Choices : int
        {
            CreditCard,
            PaymentBank
        }

        /// <summary>
        ///  Accept only credit card payments.
        /// </summary>
        public const string CreditCard = "credit_card";

        /// <summary>
        /// Accept only payment bank payments.
        /// </summary>
        public const string PaymentBank = "payment_bank";
    }
}