namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// The refund object contains information about the amount refunded and reason for the refund.
    /// </summary>
    public class RefundResponse
    {
        /// <summary>
        /// If this checkout has been fully or partially refunded, this has the amount that has already been refunded.
        /// </summary>
        public double? AmountRefunded { get; set; }

        /// <summary>
        /// If the payment was refunded the reason why.
        /// </summary>
        public string RefundReason { get; set; }
    }
}