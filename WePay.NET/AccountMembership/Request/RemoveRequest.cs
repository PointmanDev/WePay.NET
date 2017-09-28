using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.AccountMembership.Response;

namespace WePay.AccountMembership.Request
{
    public class RemoveRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.AccountMembership.Request.RemoveRequest";

        /// <summary>
        /// The unique ID of the account from which the user should be removed.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The unique ID of the user to be removed from this account.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires UserId")]
        public long? UserId { get; set; }
    }
}