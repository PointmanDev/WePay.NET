using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Settlement.Response;
using WePay.Settlement.Structure;
using WePay.Shared;

namespace WePay.Settlement.Request
{
    public class CreateRequest : WePayRequest<CreateResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Settlement.Request.CreateRequest";

        /// <summary>
        /// The unique ID of your API application.
        /// This can be located on your app dashboard.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The unique ID of the account.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The merchant's email address.
        /// This must match the email used in the User - Register call used to setup the merchant.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CaInstitution CaInstitution { get; set; }

        [ValidateWePayObject(ErrorMessage = Identifier)]
        public GbInstitution GbInstitution { get; set; }

        [ValidateWePayObject(ErrorMessage = Identifier)]
        public UsInstitution UsInstitution { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            int numberOfInitialized = 0;

            if (CaInstitution != null)
            {
                ++numberOfInitialized;
            }

            if (GbInstitution != null)
            {
                ++numberOfInitialized;
            }

            if (UsInstitution != null)
            {
                ++numberOfInitialized;
            }

            return numberOfInitialized == 0 || numberOfInitialized > 1 ? "Invalid " + Identifier + ", requires exactly one of CaInstitution, GbInstitution or UsInstitution to be non-null" : null;
        }
    }
}