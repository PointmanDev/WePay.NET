using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Order.Common
{
    /// <summary>
    /// All possible Order Statuses currently recognized by WePay
    /// </summary>
    public static class OrderStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Open,
            Processed,
            Failed
        }

        public const string Open = "open";
        public const string Processed = "processed";
        public const string Failed = "failed";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static OrderStatuses()
        {
            WePayValues.FillValuesList(typeof(OrderStatuses), Values);
        }
    }
}