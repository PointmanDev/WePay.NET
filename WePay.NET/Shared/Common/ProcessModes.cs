using System.Collections.Generic;

namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible modes the process will be displayed in.
    /// Choose iframe if you would like to frame the process on your site.
    /// </summary>
    public static class ProcessModes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Regular,
            Iframe
        }

        public const string Regular = "regular";
        public const string Iframe = "iframe";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static ProcessModes()
        {
            WePayValues.FillValuesList(typeof(ProcessModes), Values);
        }
    }
}