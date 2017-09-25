using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Account.Response;

namespace WePayApi.Account.Request
{
    public class DeleteRequest : Shared.WePayRequest<DeleteResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Request.DeleteRequest";

        /// <summary>
        /// The unique ID of the account you want to delete.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Reason for deleting the account.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Reason cannot exceed 255 characters")]
        public string Reason { get; set; }
    }
}