using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Account.Structure
{
    /// <summary>
    /// The international phone number structure contains information to construct a valid E164 formatted phone number.
    /// </summary>
    public class InternationalPhoneNumber
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Structure.InternationalPhoneNumber";

        /// <summary>
        /// Numeric country code. Optional +, followed by 1-3 digits.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires CountryCode"),
         StringLength(255, ErrorMessage = Identifier +  " - CountryCode cannot exceed 255 characters")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country code and phone number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires PhoneNumber"),
         StringLength(255, ErrorMessage = Identifier + " - PhoneNumber cannot exceed 255 characters")]
        public string PhoneNumber { get; set; }
    }
}