using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;
using WePayApi.CreditCard.Response;
using WePayApi.Shared.Common;

namespace WePayApi.CreditCard.Request
{
    public class TransferRequest : Shared.WePayRequest<StateResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Request.TransferRequest";

        /// <summary>
        /// The ID for your API application. You can find it on your app dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The secret for your API application.
        /// You can find it on your app dashboard.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ClientSecret"),
         StringLength(255, ErrorMessage = Identifier + " - ClientSecret cannot exceed 255 characters")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The number on the credit card.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires CcNumber"),
         StringLength(255, ErrorMessage = Identifier + " - CcNumber cannot exceed 255 characters")]
        public string CcNumber { get; set; }

        /// <summary>
        /// The expiration month of the credit card.
        /// Expects a value between 1 and 12
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ExpirationMonth")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// The expiration year of the credit card.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ExpirationYear")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// The full name of the user to whom the card belongs.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires UserName"),
         StringLength(255, ErrorMessage = "WePayApi.CreditCard.TransferRequest - UserName cannot exceed 255 characters")]
        public string UserName { get; set; }

        /// <summary>
        /// The email address of the user to whom the card belongs.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The billing address on the card.
        /// Only PostalCode and Country are required.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address Address { get; set; }

        /// <summary>
        /// The unique reference ID of the credit card.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The parameter that indicates whether to make a $0 authorization on the credit card being transferred.
        /// Default: false
        /// </summary>
        public bool? AutoAuthorize { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (Address != null)
            {
                if (Countries.Values.IndexOf(Address.Country) == -1)
                {
                    return "Invalid " + Identifier + ", " + " Address requires Country.";
                }
            }

            return null;
        }
    }
}