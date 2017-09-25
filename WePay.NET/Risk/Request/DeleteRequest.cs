using WePayApi.Shared;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Risk.Response;

namespace WePayApi.Risk.Request
{
    public class DeleteRequest : WePayRequest<DeleteResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Request.DeleteRequest";

        /// <summary>
        /// The unique ID of the rbit you want to delete.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires RbitId")]
        public long? RbitId { get; set; }
    }
}