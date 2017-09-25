namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// This structure contains additional information related to the payment bank payment error that occurred on a checkout.
    /// </summary>
    public class PaymentBankPaymentError
    {
        /// <summary>
        /// The bank account code.
        /// (Enumeration of these values can be found in WePayApi.Checkout.Common.PaymentBankPaymentErrors)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// A description of what the code means.
        /// See below for the mapping of the list of codes to their descriptions.
        /// </summary>
        public string Description { get; set; }
    }
}