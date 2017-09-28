using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Settlement.Structure
{
    /// <summary>
    /// Contains information about a Canadian financial institution.
    /// </summary>
    public class CaInstitution
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Settlement.Structure.GbInstitution";

        /// <summary>
        /// The name of the financial institution.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Name"),
         StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// A number that uniquely identifies a specific financial institution, used for electronic funds transmission.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires TransitNumber"),
         StringLength(255, ErrorMessage = Identifier + " - TransitNumber cannot exceed 255 characters")]
        public string TransitNumber { get; set; }

        /// <summary>
        /// A unique identifier for a Canadian bank or financial institution.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires InstitutionNumber"),
         StringLength(255, ErrorMessage = Identifier + " - InstitutionNumber cannot exceed 255 characters")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// The merchant's bank account number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires AccountNumber"),
         StringLength(255, ErrorMessage = Identifier + " - AccountNumber cannot exceed 255 characters")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The type of account to which funds are transmitted.
        /// (Enumeration of these values can be found in WePay.Shared.Common.BankAccountTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.BankAccountTypes")]
        public string AccountType { get; set; }
    }
}