using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All possible Phone Types currently supported by WePay
    /// </summary>
    public static class PhoneTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Home,
            Mobile,
            Work
        }

        public const string Home = "home";
        public const string Mobile = "mobile";
        public const string Work = "work";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PhoneTypes()
        {
            WePayValues.FillValuesList(typeof(PhoneTypes), Values);
        }
    }
}