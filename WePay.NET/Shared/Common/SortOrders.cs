using System.Collections.Generic;

namespace WePay.Shared.Common
{
    /// <summary>
    /// All possible sort orders
    /// </summary>
    public static class SortOrders
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Asc,
            Desc
        }

        public const string Asc = "asc";
        public const string Desc = "desc";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static SortOrders()
        {
            WePayValues.FillValuesList(typeof(SortOrders), Values);
        }
    }
}