using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains the user’s address information, including region and postcode.
    /// </summary>
    public class KycAddress
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.KycAddress";

        /// <summary>
        /// The street address where the user resides.
        /// In the US, this parameter must begin with a digit and not contain PO.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Address1"),
         StringLength(60, ErrorMessage = Identifier + " - Address1 cannot exceed 60 characters")]
        public string Address1 { get; set; }

        /// <summary>
        /// A continuation of the users address.
        /// </summary>
        [StringLength(60, ErrorMessage = Identifier + " - Address2 cannot exceed 60 characters")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city where the user resides.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires City"),
         StringLength(30, ErrorMessage = Identifier + " - City cannot exceed 30 characters")]
        public string City { get; set; }

        /// <summary>
        /// The region where the user resides.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Region"),
         StringLength(30, ErrorMessage = Identifier + " - Region cannot exceed 30 characters")]
        public string Region { get; set; }

        /// <summary>
        /// The postcode where the user resides.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires PostalCode"),
         StringLength(14, ErrorMessage = Identifier + " - PostalCode cannot exceed 14 characters")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country where the user resides.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Country"),
         StringLength(2, ErrorMessage = Identifier + " - Country cannot exceed 2 characters")]
        public string Country { get; set; }
    }
}