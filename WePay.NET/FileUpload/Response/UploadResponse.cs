namespace WePay.FileUpload.Response
{
    public class UploadResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the uploaded document.
        /// </summary>
        public long? FileId { get; set; }
    }
}