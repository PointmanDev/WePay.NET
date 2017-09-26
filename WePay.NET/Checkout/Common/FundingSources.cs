using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All possible payment methods which can be accepted for a check out
    /// </summary>
    public static class FundingSources
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Indices : int
        {
            CreditCard,
            PaymentBank
        }

        /// <summary>
        ///  Accept only credit card payments.
        /// </summary>
        public const string CreditCard = "credit_card";

        /// <summary>
        /// Accept only payment bank payments.
        /// </summary>
        public const string PaymentBank = "payment_bank";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static FundingSources()
        {
            WePayValues.FillValuesList(typeof(FundingSources), Values);
        }
    }
}