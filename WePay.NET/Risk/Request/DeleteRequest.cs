using WePay.Shared;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Risk.Response;

namespace WePay.Risk.Request
{
    public class DeleteRequest : WePayRequest<DeleteResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Request.DeleteRequest";

        /// <summary>
        /// The unique ID of the rbit you want to delete.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires RbitId")]
        public long? RbitId { get; set; }
    }
}