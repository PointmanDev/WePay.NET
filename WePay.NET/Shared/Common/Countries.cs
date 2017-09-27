using System.Collections.Generic;

namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All countries currently supported by WePay
    /// </summary>
    public static class Countries
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            US,
            CA,
            GB
        }

        /// <summary>
        /// United States
        /// </summary>
        public const string US = "US";

        /// <summary>
        /// Canada
        /// </summary>
        public const string CA = "CA";

        /// <summary>
        /// Great Britain
        /// </summary>
        public const string GB = "GB";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Countries()
        {
            WePayValues.FillValuesList(typeof(Countries), Values);
        }
    }
}