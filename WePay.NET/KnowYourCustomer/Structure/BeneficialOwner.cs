using Newtonsoft.Json;
using WePay.Shared;

namespace WePay.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains basis identity and location information about a beneficial owner.
    /// </summary>
    public class BeneficialOwner
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Structure.BeneficialOwner";

        /// <summary>
        /// The name of the beneficial owner.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Name Name { get; set; }

        /// <summary>
        /// The address of the beneficial owner.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public KycAddress Address { get; set; }

        /// <summary>
        /// The birthdate of the beneficial owner.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Date DateOfBirth { get; set; }
    }
}