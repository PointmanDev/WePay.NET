using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains information identifying a US Owner as a valid person.
    /// TIP: SocialSecurityNumberLast4 is accepted for all US merchants upon the first submission of KYC.
    /// The full 9 SocialSecurityNumber must be submitted for US merchants of type individual that do not pass synchronous KYC validation upon the first submission.
    /// </summary>
    public class UsOwnerCompliance : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.AccountOwner";

        /// <summary>
        /// The user's government issued Social Security Number (SSN), used for identification.
        /// The SSN must be in form nnn-nn-nnnn where only digits between 0 and 9 are valid.
        /// /// </summary>
        [StringLength(11, ErrorMessage = Identifier + "- SocialSecurityNumber must be exactly 11 digits", MinimumLength = 11),
         RegularExpression(@"^\d{3}-?\d{2}-?\d{4}$", ErrorMessage = Identifier + " - SocialSecurityNumber must be of the form nnn-nn-nnnn where n is a digit between 0 and 9")]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The last four digits of the user's goverment issued Social Security Number (SSN).
        /// The number must be exactly 4 digits(values 0 through 9) in length.
        /// </summary>
        [StringLength(4, ErrorMessage = Identifier + " - SocialSecurityNumberLastFour must be exactly 4 digits", MinimumLength = 4),
         RegularExpression(@"^\d{4}$", ErrorMessage = Identifier + " - SocialSecurityNumberLastFour can only include digits between 0 and 9")]
        public string SocialSecurityNumberLast4 { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string errorPrefix = "Invalid " + Identifier + ", ";

            if (SocialSecurityNumber == null && SocialSecurityNumberLast4 == null)
            {
                return errorPrefix + " requires SocialSecurityNumber or SocialSecurityNumberLast4";
            }

            if (SocialSecurityNumber != null && SocialSecurityNumberLast4 != null)
            {
                return errorPrefix + " only one of SocialSecurityNumber or SocialSecurityNumberLast4 can be non-null";
            }

            return null;
        }
    }
}