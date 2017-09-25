using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;

namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// Use this to have payers enter payment information on a WePay hosted checkout URL.
    /// Send either HostedChecout or PaymentMethod parameter.
    /// Do not send both parameters at the same time.
    /// If neither parameter is specified, default behavior will be HostedCheckout.
    /// </summary>
    public class HostedCheckout
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Structure.HostedCheckout";

        /// <summary>
        /// The URI the payer will be redirected to after payment (if available).
        /// If you do not pass a RedirectUri, the user will see a payment confirmation page
        /// (and if you are using the iFrame we will send a postMessage to the parent window indicating that the payment is complete).
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - RedirectUri cannot exceed 60 characters")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// What mode the checkout will be displayed in.
        /// The options are iframe or regular.
        /// Choose iframe if this is an iframe checkout.
        /// Default: regular
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.ProcessModes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.ProcessModes")]
        public string Mode { get; set; }

        /// <summary>
        /// The URI used to redirect the payer if 3rd party cookies are not enabled for iframes.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - FallbackUri cannot exceed 60 characters")]
        public string FallbackUri { get; set; }

        /// <summary>
        /// The amount to be charged for shipping the item.
        /// </summary>
        public double? ShippingFee { get; set; }

        /// <summary>
        /// If set to true, then the payer will be required to enter their shipping address when paying.
        /// Default: false
        /// </summary>
        public bool? RequireShipping { get; set; }

        /// <summary>
        /// Information about payer to pre-fill certain fields in checkout flow.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public PaymentsPrefillInfo PrefillInfo { get; set; }

        /// <summary>
        /// What payment method to accept for this checkout.
        /// Must be sent as an array.
        /// (Enumeration of these values can be found in WePayApi.Checkout.Common.FundingSources)
        /// For example, if only "credit_card" is selected, customers will see option to pay by credit card when they go to the
        /// WePay hosted checkout URL.
        /// They will not be able to pay using their bank account.
        /// If the FundingSources parameter is not specified, both credit card and bank account payments will be accepted in the checkout flow.
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Checkout.Common.FundingSources")]
        public string[] FundingSources { get; set; }

        /// <summary>
        /// The theme structure contains information to provide custom look-and-feel for the flows and emails.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Theme ThemeObject { get; set; }
    }
}