using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Settlement.Structure
{
    /// <summary>
    /// Contains information about a UK financial Institution.
    /// </summary>
    public class GbInstitution
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
        /// A six digit bank code used to route money transfers between banks.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires SortCode"),
         StringLength(6, ErrorMessage = Identifier + " - SortCode cannot exceed 6 characters")]
        public string SortCode { get; set; }

        /// <summary>
        /// The merchant's account number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires AccountNumber"),
         StringLength(8, ErrorMessage = Identifier + " - AccountNumber cannot exceed 8 characters")]
        public string AccountNumber { get; set; }
    }
}