using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;

namespace WePay.Account.Request
{
    public class DeleteRequest : Shared.WePayRequest<DeleteResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.DeleteRequest";

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