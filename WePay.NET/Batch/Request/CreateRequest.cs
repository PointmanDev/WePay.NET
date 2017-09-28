using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Batch.Response;
using WePay.Batch.Structure;
using WePay.Shared;

namespace WePay.Batch.Request
{
    public class CreateRequest : WePayRequest<BulkCreateResponse>
    {
        [JsonIgnore]
        public const string Identifier = "WePay.Batch.Request.CreateRequest";

        /// <summary>
        /// The ID for your API application. It can found on your application's dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application. It can found on your application's dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// An array of the API calls you want to make.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public ApiCall[] Calls { get; set; }
    }
}