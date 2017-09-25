using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.FileUpload.Response;
using WePayApi.Shared;

namespace WePayApi.FileUpload.Request
{
    public class UploadRequest : WePayRequest<UploadResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.FileUpload.Request.UploadRequest";

        /// <summary>
        /// The document being uploaded on behalf of the merchant for WePay review.
        /// Possible file extensions: pdf, jpg, jpeg, png, or no extension.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires File")]
        public byte[] File { get; set; }

        /// <summary>
        /// The type of file being uploaded.
        /// (Enumeration of these values can be found in WePayApi.FileUpload.Common.FileTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.FileUpload.Common.FileTypes")]
        public string Type { get; set; }

        /// <summary>
        /// The associated merchant’s unique account ID.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}