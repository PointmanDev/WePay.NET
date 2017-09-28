using System.Collections.Generic;

namespace WePay.Shared.Common
{
    /// <summary>
    /// All currencies currently supported by WePay
    /// </summary>
    public static class Currencies
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            USD,
            CAD,
            GBP
        }

        /// <summary>
        /// US Dollar
        /// </summary>
        public const string USD = "USD";

        /// <summary>
        /// Canadian Dollar
        /// </summary>
        public const string CAD = "CAD";

        /// <summary>
        /// Great British Pound
        /// </summary>
        public const string GBP = "GBP";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Currencies()
        {
            WePayValues.FillValuesList(typeof(Currencies), Values);
        }
    }
}