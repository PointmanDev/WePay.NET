using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Batch.Structure
{
    /// <summary>
    /// Contains API calls and their associated arguments.
    /// </summary>
    public class ApiCall
    {
        [JsonIgnore]
        protected const string Identifier = "WePay.Batch.Structure.ApiCall";

        /// <summary>
        /// The name of the call you want to make (e.g. WePay.Checkout.CheckoutService.EndPointUrls.Create)
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Call"),
         StringLength(255, ErrorMessage = Identifier + " - Call cannot exceed 255 characters")]
        public string Call { get; set; }

        /// <summary>
        /// The access token of the user making the API call.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Authorization"),
         StringLength(255, ErrorMessage = Identifier + " - Authorization cannot exceed 255 characters")]
        public string Authorization { get; set; }

        /// <summary>
        /// A unique ID you can attach to an API call to identify it.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }
    }

    public class ApiCall<T> : ApiCall where T : WePayResponse
    {
        /// <summary>
        /// The parameters required by the API call specified in the call parameter.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public WePayRequest<T> Parameters { get; set; }
    }
}