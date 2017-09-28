namespace WePay.Checkout.Structure
{
    /// <summary>
    /// This structure contains additional information about a payment error that occurred on a checkout.
    /// At present, only Pay With Bank (ACH) transactions may have additional information.
    /// </summary>
    public class PaymentError
    {
        /// <summary>
        /// The error type.
        /// This is set to payment_bank and matches the corresponding object type below.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.PaymentTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Information regarding the error regarding the payment using a bank account.
        /// </summary>
        public PaymentBankPaymentError PaymentBank { get; set; }
    }
}