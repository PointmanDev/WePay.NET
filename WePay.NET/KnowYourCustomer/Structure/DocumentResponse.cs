namespace WePay.KnowYourCustomer.Structure
{
    /// <summary>
    /// The Document Response structure show file metadata for documents that have been uploaded to WePay.
    /// </summary>
    public class DocumentResponse
    {
        /// <summary>
        /// Unique FileId from the FileUpload Upload
        /// </summary>
        public long? FileId { get; set; }

        /// <summary>
        /// The document type, as specified when uploaded.
        /// (Enumeration of these values can be found in WePay.FileUpload.Common.FileTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The document's WePay review state. 
        /// (Enumeration of these values can be found in WePay.FileUpload.Common.FileStatuses)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The reason why the document was rejected during review (if applicable).
        /// This is guaranteed to be non-null if the document's state is 'Rejected', otherwise, it will be null.
        /// (Enumeration of these values can be found in WePay.FileUpload.Common.RejectReasons)
        /// </summary>
        public string RejectReason { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) (in seconds) when the document was uploaded to WePay.
        /// </summary>
        public long? CreateTime { get; set; }
    }
}