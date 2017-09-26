using WePayApi.Shared;

namespace WePayApi.FileUpload.Common
{
    /// <summary>
    /// All possible reasons that a document is rejected by WePay
    /// </summary>
    public class RejectReasons : WePayValues<RejectReasons>
    {
        public enum Indices : int
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
    }
}