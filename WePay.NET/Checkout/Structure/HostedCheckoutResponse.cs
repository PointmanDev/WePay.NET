using WePayApi.Shared.Structure;

namespace WePayApi.Checkout.Structure
{
    public class HostedCheckoutResponse
    {
        /// <summary>
        /// The URI for the Checkout.
        /// </summary>
        public string CheckoutUri { get; set; }

        /// <summary>
        /// What mode the checkout was displayed in.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.ProcessModes)
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// The URI the payer will be redirected to after payment (if available).
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// The amount to be charged for shipping the item.
        /// </summary>
        public double? ShippingFee { get; set; }

        /// <summary>
        /// If set to true, then the payer was required to enter their shipping address when paying.
        /// </summary>
        public bool? RequireShipping { get; set; }

        /// <summary>
        /// If RequireShipping was set to true and the payment was made, this will be the shipping address that the payer entered.
        /// If this value is null then either RequireShipping is false, or the payer has not yet completed checkout.
        /// </summary>
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// The theme structure contains information to provide custom look-and-feel for the flows and emails.
        /// </summary>
        public Theme ThemeObject { get; set; }
    }
}