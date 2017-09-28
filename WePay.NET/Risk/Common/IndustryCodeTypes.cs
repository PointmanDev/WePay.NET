using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All possible Industry Code Types currently supported by WePay
    /// </summary>
    public static class IndustryCodeTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Mcc,
            Sic,
            Naics
        }

        public const string Mcc = "mcc";
        public const string Sic = "sic";
        public const string Naics = "naics";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static IndustryCodeTypes()
        {
            WePayValues.FillValuesList(typeof(IndustryCodeTypes), Values);
        }
    }
}