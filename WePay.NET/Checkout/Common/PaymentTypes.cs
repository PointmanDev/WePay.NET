using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    public class PaymentTypes : WePayValues<PaymentTypes>
    {
        public enum Choices : int
        {
            CreditCard,
            PaymentBank,
            Preapproval
        }

        public const string CreditCard = "credit_card";
        public const string PaymentBank = "payment_bank";
        public const string Preapproval = "preapproval";
    }
}