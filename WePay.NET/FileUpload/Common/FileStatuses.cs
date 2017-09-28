using System.Collections.Generic;
using WePay.Shared;

namespace WePay.FileUpload.Common
{
    /// <summary>
    /// All possible File Statuses currently recognized by WePay
    /// </summary>
    public static class FileStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Verified,
            InReview,
            Rejected
        }

        public const string Verified = "verified";
        public const string InReview = "in_review";
        public const string Rejecte = "rejected";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static FileStatuses()
        {
            WePayValues.FillValuesList(typeof(FileStatuses), Values);
        }
    }
}