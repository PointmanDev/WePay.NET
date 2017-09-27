using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All Payment Types currently supported by WePay
    /// </summary>
    public static class PaymentTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            CreditCard,
            PaymentBank,
            Preapproval
        }

        public const string CreditCard = "credit_card";
        public const string PaymentBank = "payment_bank";
        public const string Preapproval = "preapproval";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PaymentTypes()
        {
            WePayValues.FillValuesList(typeof(PaymentTypes), Values);
        }
    }
}