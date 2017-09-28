namespace WePay.Checkout.Response
{
    public class StateResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the checkout that was successfully cancelled or refunded
        /// </summary>
        public long? CheckoutId { get; set; }

        /// <summary>
        /// The state the payment is in.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.CheckoutStates)
        /// </summary>
        public string State { get; set; }
    }
}