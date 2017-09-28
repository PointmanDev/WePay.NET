using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.KnowYourCustomer.Response;

namespace WePay.KnowYourCustomer.Request
{
    public class AuthorizeRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Request.AuthorizeRequest";

        /// <summary>
        /// A unique KYC ID returned by the /account/kyc/create call.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? KycId { get; set; }
    }
}