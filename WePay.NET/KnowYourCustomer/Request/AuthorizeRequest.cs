using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.KnowYourCustomer.Response;

namespace WePayApi.KnowYourCustomer.Request
{
    public class AuthorizeRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Request.AuthorizeRequest";

        /// <summary>
        /// A unique KYC ID returned by the /account/kyc/create call.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? KycId { get; set; }
    }
}