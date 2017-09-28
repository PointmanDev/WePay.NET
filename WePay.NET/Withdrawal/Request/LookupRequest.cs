using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Withdrawal.Response;

namespace WePay.Withdrawal.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Withdrawal.Request.LookupRequest";

        /// <summary>
        /// The unique ID of a withdrawal you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires WithdrawalId")]
        public long? WithdrawalId { get; set; }
    }
}