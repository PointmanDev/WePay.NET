using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Withdrawal.Response;

namespace WePayApi.Withdrawal.Request
{
    public class ModifyRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Withdrawal.Request.ModifyRequest";

        /// <summary>
        /// The unique ID of a withdrawal you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires WithdrawalId")]
        public long? WithdrawalId { get; set; }

        /// <summary>
        /// The URI that will receive POST notifications each time the withdrawal changes state.
        /// See the instant payment notifications guide for more details. This must be a full URI (ex https://www.example.com ) and must not localhost or 127.0.0.1, or include wepay.com.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }
    }
}