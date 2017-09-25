using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains the user’s or entity’s registered phone number.
    /// </summary>
    public class Phone
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.Phone";

        /// <summary>
        /// The country code of the primary phone number entered by the user.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "WePayApi.Shared.Structure.Phone - Requires CountryCode"),
         StringLength(255, ErrorMessage = "WePayApi.Shared.Structure.Phone - CountryCode cannot exceed 255 characters")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The primary phone number entered by the user.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "WePayApi.Shared.Structure.Phone - Requires PhoneNumber"),
         StringLength(255, ErrorMessage = "WePayApi.Shared.Structure.Phone - PhoneNumber cannot exceed 255 characters")]
        public string PhoneNumber { get; set; }
    }
}