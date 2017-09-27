using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.FileUpload.Common
{
    /// <summary>
    /// All possible reasons that a document is rejected by WePay
    /// </summary>
    public static class RejectReasons
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Illegible,
            CorruptFile,
            InfoMismatch,
            DocUnsupported,
            Incomplete
        }

        public const string Illegible = "illegible";
        public const string CorruptFile = "corrupt_fsile";
        public const string InfoMismatch = "info_mismatch";
        public const string DocUnsupported = "doc_unsupported";
        public const string Incomplete = "incomplete";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static RejectReasons()
        {
            WePayValues.FillValuesList(typeof(RejectReasons), Values);
        }
    }
}