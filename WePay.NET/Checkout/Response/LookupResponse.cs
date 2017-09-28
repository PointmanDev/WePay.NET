using WePay.Checkout.Structure;

namespace WePay.Checkout.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the checkout.
        /// </summary>
        public long? CheckoutId { get; set; }

        /// <summary>
        /// The unique ID of the account that the money will go into.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The checkout type.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.CheckoutTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) when the checkout was created.
        /// </summary>
        public long? CreateTime { get; set; }

        /// <summary>
        /// The state the checkout is in.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.CheckoutStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The payment description that will show up on payer's credit card statement.
        /// </summary>
        public string SoftDescriptor { get; set; }

        /// <summary>
        /// The URI to which IPNs are sent.
        /// </summary>
        public string CallbackUri { get; set; }

        /// <summary>
        /// A short description of the checkout.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// A longer, more detailed, description of the checkout (if available).
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// The currency used.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The dollar amount of the Checkout (e.g., 3.20).
        /// This will always be the amount you passed in the Create call.
        /// </summary>
        public double? Amount { get; set; }

        /// <summary>
        /// Specifies whether an app fee was collected and who (the app or customer) paid for it.
        /// </summary>
        public FeeResponse Fee { get; set; }

        /// <summary>
        /// The total dollar amount paid by the payer.
        /// </summary>
        public double? Gross { get; set; }

        /// <summary>
        /// If set to false then the payment will not automatically be released to the account and will be held by WePay in payment state captured.
        /// To release funds to the account you must make a Release call.
        /// If you do not release the funds within 14 days, then the payment will be automatically cancelled or refunded.
        /// Default: true
        /// PERMISSION REQUIRED
        /// </summary>
        public bool? AutoRelease { get; set; }

        /// <summary>
        /// Indicates whether the checkout is under review by the WePay risk team or not.
        /// </summary>
        public bool? InReview { get; set; }

        /// <summary>
        /// Specifies the amount charged back and the dispute URL.
        /// </summary>
        public ChargebackResponse Chargeback { get; set; }

        /// <summary>
        /// The unique ID passed by the application (if available).
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Specifies the amount refunded and the reason for refund.
        /// </summary>
        public RefundResponse Refund { get; set; }

        /// <summary>
        /// Specifies the payment method used for the checkout.
        /// Note that only one of either PaymentMethod or HostedCheckout may be present.
        /// </summary>
        public PaymentMethodResponse PaymentMethod { get; set; }

        /// <summary>
        /// Specifies CheckoutUri, RedirectUri, Shipping Information, and Process Mode (whether the checkout was displayed in an iframe or not).
        /// Note that only one of either PaymentMethod or HostedCheckout may be present.
        /// </summary>
        public HostedCheckoutResponse HostedCheckout { get; set; }

        /// <summary>
        /// Payer information, returned if payment was made.
        /// </summary>
        public PayerResponse Payer { get; set; }

        /// <summary>
        /// Delivery type for checkout.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.DeliveryTypes)
        /// </summary>
        public string DeliveryType { get; set; }

        /// <summary>
        /// If the payee is a non profit entity, the structure contains information about non profit organization.
        /// </summary>
        public NonProfitInformation NpoInformation { get; set; }

        /// <summary>
        /// If there is an error regarding the payment and WePay has additional information to pass back, this will contain that information.
        /// At present, only Pay With Bank (ACH) transactions may have additional information.
        /// </summary>
        public PaymentError PaymentError { get; set; }

        /// <summary>
        /// Array of rbit ids associated with the checkout payer.
        /// </summary>
        public string[] PaymentRbitIds { get; set; }

        /// <summary>
        /// Array of rbit ids associated with the checkout transaction.
        /// </summary>
        public string[] TransactionRbitIds { get; set; }
    }
}