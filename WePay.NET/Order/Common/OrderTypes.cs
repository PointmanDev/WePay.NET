using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Order.Common
{
    /// <summary>
    /// All possible Order Types currently recognized by WePay
    /// </summary>
    public static class OrderTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            CardReader = 0
        }

        public const string CardReader = "card_reader";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static OrderTypes()
        {
            WePayValues.FillValuesList(typeof(OrderTypes), Values);
        }
    }
}