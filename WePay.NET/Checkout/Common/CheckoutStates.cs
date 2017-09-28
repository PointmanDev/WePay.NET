using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Checkout.Common
{
    /// <summary>
    /// All possible checkout states
    ///  (you can receive callback notifications when the checkout changes state,
    ///  please read our Instant Payment Notification (IPN) Tutorial (https://www.wepay.com/developer/reference/ipn) for more details)
    /// </summary>
    public static class CheckoutStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            New,
            Authorized,
            Captured,
            Released,
            Cancelled,
            Refunded,
            ChargedBack,
            Failed,
            Expired
        }

        /// <summary>
        /// The checkout was created by the application. 
        /// his state only exists for checkouts created in WePay's hosted checkout flow.
        /// </summary>
        public const string New = "new";

        /// <summary>
        /// The payer entered their payment info and confirmed the payment on WePay.
        /// WePay has successfully charged the card.
        /// </summary>
        public const string Authorized = "authorized";

        /// <summary>
        /// The payment has been reserved from the payer.
        /// </summary>
        public const string Captured = "captured";

        /// <summary>
        /// The payment has been credited to the payee account.
        /// Note that the released state may be active although there are active partial refunds or partial chargebacks.
        /// </summary>
        public const string Released = "released";

        /// <summary>
        /// The payment has been cancelled by the payer, payee, or application.
        /// </summary>
        public const string Cancelled = "cancelled";

        /// <summary>
        /// The payment was captured and then refunded by the payer, payee, or application.
        /// The payment has been debited from the payee account.
        /// </summary>
        public const string Refunded = "refunded";

        /// <summary>
        /// The payment has been charged back by the payer and the payment has been debited from the payee account.
        /// </summary>
        public const string ChargedBack = "charged_back";

        /// <summary>
        /// The payment has failed.
        /// </summary>
        public const string Failed = "failed";

        /// <summary>
        /// Checkouts expire if they remain in the new state for more than 30 minutes (e.g., they have been abandoned).
        /// This state only exists for checkouts created in WePay's hosted checkout flow.
        /// </summary>
        public const string Expired = "expired";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static CheckoutStates()
        {
            WePayValues.FillValuesList(typeof(CheckoutStates), Values);
        }
    }
}