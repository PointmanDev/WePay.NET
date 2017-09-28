using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Account.Structure
{
    /// <summary>
    /// Contains destination address information for a settlement check.
    /// </summary>
    public class SendCheckToAddress
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Structure.SendCheckToAddress";

        /// <summary>
        /// The street address where the check is to be sent.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Address1"),
         StringLength(60, ErrorMessage = Identifier + " - Address1 cannot exceed 60 characters")]
        public string Address1 { get; set; }

        /// <summary>
        /// Additional address information.
        /// </summary>
        [StringLength(60, ErrorMessage = Identifier + " - Address2 cannot exceed 60 characters")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city portion of the address where the check is to be sent.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires City"),
         StringLength(30, ErrorMessage = Identifier + " - City cannot exceed 30 characters")]
        public string City { get; set; }

        /// <summary>
        /// The state, province, or postal region where the check is to be sent.
        /// Must be from 0 to 30 characters in length and must consist of uppercase letters.
        /// Conformance to ISO 3166-2 is preferred but not required.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Region"),
         StringLength(30, ErrorMessage = Identifier + " - Region cannot exceed 30 characters"),
         RegularExpression(@"^[A-Z\s]*$", ErrorMessage = Identifier + " - Region must be from 0 to 30 characters in length and must consist of uppercase letters")]
        public string Region { get; set; }

        /// <summary>
        /// The postal code for the check address.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires PostalCode"),
         StringLength(14, ErrorMessage = Identifier + " - PostalCode cannot exceed 14 characters")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country where the check is to be sent.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Country"),
         StringLength(2, ErrorMessage = Identifier + " - Country cannot exceed 2 characters")]
        public string Country { get; set; }
    }
}