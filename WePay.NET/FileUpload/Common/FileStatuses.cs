using WePayApi.Shared;

namespace WePayApi.FileUpload.Common
{
    /// <summary>
    /// All possible File Statuses currently recognized by WePay
    /// </summary>
    public class FileStatuses : WePayValues<FileStatuses>
    {
        public enum Indices : int
        {
            Verified,
            InReview,
            Rejected
        }

        public const string Verified = "verified";
        public const string InReview = "in_review";
        public const string Rejecte = "rejected";
    }
}