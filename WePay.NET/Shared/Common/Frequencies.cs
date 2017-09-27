using System.Collections.Generic;

namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible frequencies supported by WePay
    /// </summary>
    public static class Frequencies
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Daily,
            Weekly,
            Monthly
        }

        public const string Daily = "daily";
        public const string Weekly = "weekly";
        public const string Monthly = "monthly";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Frequencies()
        {
            WePayValues.FillValuesList(typeof(Frequencies), Values);
        }
    }
}