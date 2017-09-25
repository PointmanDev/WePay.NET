using Newtonsoft.Json;
using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// This structure is used only for entities in Great Britain.
    /// </summary>
    public class GbEntityCompliance
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.GbEntityCompliance";

        /// <summary>
        /// The company number used to validate a legal business in the UK.
        /// </summary>
        public string CompanyNumber { get; set; }

        /// <summary>
        /// The type of business.
        /// (Enumeration of these values can be found in WePayApi.KnowYourCustomer.Common.LegalForms)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.KnowYourCustomer.Common.LegalForms")]
        public string LegalForm { get; set; }

        /// <summary>
        /// Owners the holds more than 25 percent of the company.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public BeneficialOwner[] BeneficialOwners { get; set; }
    }
}