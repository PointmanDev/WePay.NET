using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.KnowYourCustomer.Structure;
using WePayApi.Shared;

namespace WePayApi.Account.Structure
{
    /// <summary>
    /// Contains information about a merchant that can be used to prefill fields in the Know Your Customer (KYC) form.
    /// </summary>
    public class KycPrefillInfo
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Structure.KycPrefillInfo";

        /// <summary>
        /// The legal name of the account owner.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Name Name { get; set; }

        /// <summary>
        /// The email address of the account owner.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the account owner.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Phone Phone { get; set; }

        /// <summary>
        /// The phone number of the entity.
        /// Note: This is used for businesses and organizations, not individuals.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Phone EntityPhone { get; set; }

        /// <summary>
        /// The full address of the account owner.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public KycAddress Address { get; set; }

        /// <summary>
        /// The full address of the entity.
        /// Note: This is used for businesses and organizations, not individuals.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public KycAddress EntityAddress { get; set; }

        /// <summary>
        /// The date of birth of the account owner.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Date DateOfBirth { get; set; }

        /// <summary>
        /// Name of the entity completing KYC.
        /// Note: This is used for businesses and organizations, not individuals.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - EntityName cannot exceed 255 characters")]
        public string EntityName { get; set; }

        /// <summary>
        /// URL that identifies the entity completing KYC.
        /// Note: This is used for businesses and organizations, not individuals.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + "- Url cannot exceed 2083 characters")]
        public string Url { get; set; }

        /// <summary>
        /// Description of the entity completing KYC
        /// Note: This is used for businesses and organizations, not individuals.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Description cannot exceed 255 characters")]
        public string Description { get; set; }
    }
}