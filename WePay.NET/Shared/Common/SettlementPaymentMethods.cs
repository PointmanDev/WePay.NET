using System.Collections.Generic;

namespace WePay.Shared.Common
{
    /// <summary>
    /// All possible settlement payment methods currently supported by WePay
    /// </summary>
    public static class SettlementPaymentMethods
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Ach,
            Check
        }

        public const string Ach = "ach";
        public const string Check = "check";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static SettlementPaymentMethods()
        {
            WePayValues.FillValuesList(typeof(SettlementPaymentMethods), Values);
        }
    }
}