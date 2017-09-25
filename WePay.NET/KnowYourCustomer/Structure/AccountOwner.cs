using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains details about the owner of an account.
    /// </summary>
    public class AccountOwner : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.AccountOwner";

        [JsonIgnore]
        private const string UsComplianceField = "UsOwnerCompliance";

        [JsonIgnore]
        private const string CaComplianceField = "CaOwnerCompliance";

        [JsonIgnore]
        private const string GbComplianceField = "GbOwnerCompliance";

        /// <summary>
        /// The user's full name.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Name Name { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The user's date of birth.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Date DateOfBirth { get; set; }

        /// <summary>
        /// The user's full address
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public KycAddress Address { get; set; }

        /// <summary>
        /// The user's phone number.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Phone Phone { get; set; }

        /// <summary>
        /// Canada specific owner fields.
        /// Required for Canadian entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CaOwnerCompliance CaOwnerCompliance { get; set; }

        /// <summary>
        /// UK specific owner information.
        /// Required for UK entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public GbOwnerCompliance GbOwnerCompliance { get; set; }

        /// <summary>
        /// U.S. specific owner information.
        /// Required for US entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public UsOwnerCompliance UsOwnerCompliance { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            return KnowYourCustomerService.GetComplianceAdditonalValidationErrorMessage(Identifier,
                                                                                        Address,
                                                                                        UsOwnerCompliance != null,
                                                                                        CaOwnerCompliance != null,
                                                                                        GbOwnerCompliance != null,
                                                                                        UsComplianceField,
                                                                                        CaComplianceField,
                                                                                        GbComplianceField);
        }
    }
}