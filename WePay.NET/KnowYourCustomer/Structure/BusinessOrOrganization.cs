using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains information about the business owner, the name, address, and website of the business OR
    /// This structure describes an organization and its compliance information.
    /// </summary>
    public class BusinessOrOrganization : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.BusinessOrOrganization";

        [JsonIgnore]
        private const string UsComplianceField = "UsEntityCompliance";

        [JsonIgnore]
        private const string CaComplianceField = "CaEntityCompliance";

        [JsonIgnore]
        private const string GbComplianceField = "GbEntityCompliance";

        /// <summary>
        /// Information about the account owner.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public AccountOwner AccountOwner { get; set; }

        /// <summary>
        /// The name of the business.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires LegalEntityName"),
         StringLength(255, ErrorMessage = Identifier + " - LegalEntityName cannot exceed 255 characters")]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// The URL of the business website.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires PrimaryUrl"),
         StringLength(255, ErrorMessage = Identifier + " - PrimaryUrl cannot exceed 255 characters")]
        public string PrimaryUrl { get; set; }

        /// <summary>
        /// A description of the business.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires EntityDescription"),
         StringLength(255, ErrorMessage = Identifier + " - EntityDescription cannot exceed 255 characters")]
        public string EntityDescription { get; set; }

        /// <summary>
        /// The full business address.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public KycAddress Address { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) that specifies the industry associated with the business.
        /// See the MCC Page (https://www.wepay.com/developer/reference/mcc) for more information.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Mcc cannot exceed 255 characters")]
        public string Mcc { get; set; }

        /// <summary>
        /// Canada specific fields. Required for Canadian entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CaEntityCompliance CaEntityCompliance { get; set; }

        /// <summary>
        /// UK specific fields. Required for UK entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public GbEntityCompliance GbEntityCompliance { get; set; }

        /// <summary>
        /// US specific fields. Required for US entities only.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public UsEntityCompliance UsEntityCompliance { get; set; }

        private string BuildErrorMessage(string extraField = null,
                                         bool matchesCountry = false)
        {
            return (matchesCountry ? "requires " : "Address marked as " + Address.Country + " but contains non-null ")
                + extraField
                + "\n";
        }

        public string GetAdditonalValidationErrorMessage()
        {
            return KnowYourCustomerService.GetComplianceAdditonalValidationErrorMessage(Identifier,
                                                                                        Address,
                                                                                        UsEntityCompliance != null,
                                                                                        CaEntityCompliance != null,
                                                                                        GbEntityCompliance != null,
                                                                                        UsComplianceField,
                                                                                        CaComplianceField,
                                                                                        GbComplianceField);
        }
    }
}