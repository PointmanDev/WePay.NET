using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.Settlement.Structure
{
    /// <summary>
    /// Contains information about a US financial institution.
    /// </summary>
    public class UsInstitution
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Settlement.Structure.UsInstitution";

        /// <summary>
        /// The name of the institution.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Name"),
         StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// A unique identifier indicating a specific US financial institution.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires RoutingNumber"),
         StringLength(255, ErrorMessage = Identifier + " - RoutingNumber cannot exceed 255 characters")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The merchant's account number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires AccountNumber"),
         StringLength(255, ErrorMessage = Identifier + " - AccountNumber cannot exceed 255 characters")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The type of account to which funds are transmitted.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.BankAccountTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.BankAccountTypes")]
        public string AccountType { get; set; }
    }
}