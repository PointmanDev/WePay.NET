namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// Contains information about the payment method used.
    /// </summary>
    public class PaymentMethodResponse
    {
        /// <summary>
        /// Payment Method type used in payment.
        /// Can be credit_card or payment_bank.
        /// (Enumeration of these values can be found in WePayApi.Shared.Checkout.PaymentTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Object that specifies the credit card used in payment.
        /// Available if type is credit_card.
        /// </summary>
        public CreditCard.Structure.CreditCard CreditCard { get; set; }

        /// <summary>
        /// Object that specifies the payment bank used in payment.
        /// Available if type is payment_bank.
        /// </summary>
        public PaymentBank.Structure.PaymentBank PaymentBank { get; set; }

        /// <summary>
        /// [DEPRECATED] The preapproval ID from the Preapproval Create call.
        /// </summary>
        public long? Preapproval { get; set; }
    }
}