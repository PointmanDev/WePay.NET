using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Order.Common
{
    /// <summary>
    /// All possible statuses for tracking information pertaining to a given order
    /// </summary>
    public static class TrackingInformationStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Shipped,
            Delivered,
            Returned
        }

        public const string Shipped = "shipped";
        public const string Delivered = "delivered";
        public const string Returned = "returned";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static TrackingInformationStatuses()
        {
            WePayValues.FillValuesList(typeof(TrackingInformationStatuses), Values);
        }
    }
}
