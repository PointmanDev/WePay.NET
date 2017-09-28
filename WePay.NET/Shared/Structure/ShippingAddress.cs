using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Shared.Structure
{
    /// <summary>
    /// The shipping address structure contains information about a shipping address.
    /// </summary>
    public class ShippingAddress
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Shared.Structure.ShippingAddress";

        /// <summary>
        /// The name of the person.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The first line of the street address.
        /// </summary>
        [StringLength(60, ErrorMessage = Identifier + " - Address1 cannot exceed 60 characters")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the street address.
        /// </summary>
        [StringLength(60, ErrorMessage = Identifier + " - Address2 cannot exceed 60 characters")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [StringLength(30, ErrorMessage = Identifier + " - City cannot exceed 30 characters")]
        public string City { get; set; }

        /// <summary>
        /// Must be the 2-letter US state code for US addresses.
        /// Represents subdivisions (e.g. provinces or states) for other countries.
        /// 2-letter province codes are supported for Canada.
        /// 3-letter region codes are supported for Great Britain.
        /// </summary>
        [StringLength(30, ErrorMessage = Identifier + " - Region cannot exceed 30 characters")]
        public string Region { get; set; }

        /// <summary>
        /// The the postcode/zip for the address.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires PostalCode"),
         StringLength(14, ErrorMessage = Identifier + " - PostalCode cannot exceed 14 characters")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The 2-letter ISO-3166-1 country code.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Countries)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Countries")]
        public string Country { get; set; }
    }
}