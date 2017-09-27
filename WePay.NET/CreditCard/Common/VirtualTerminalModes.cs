using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.CreditCard.Common
{
    /// <summary>
    /// All possible virtual terminal modes
    /// </summary>
    public static class VirtualTerminalModes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Mobile,
            Web,
            None
        }

        public const string Mobile = "mobile";
        public const string Web = "web";
        public const string None = "none";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static VirtualTerminalModes()
        {
            WePayValues.FillValuesList(typeof(VirtualTerminalModes), Values);
        }
    }
}