using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains the full name of the user.
    /// CAUTION:  WePay concatenates the first and middle names and then truncates the string to the first 35 characters.
    /// </summary>
    public class Name
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.Name";

        /// <summary>
        /// The user's first name.
        /// Truncated after the first 35 characters.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Required First"),
         StringLength(35, ErrorMessage = Identifier + " - First cannot exceed 35 characters")]
        public string First { get; set; }

        /// <summary>
        /// The user's middle name.
        /// Truncated after the first 35 characters.
        /// </summary>
        [StringLength(35, ErrorMessage = Identifier + " - Middle cannot exceed 35 characters")]
        public string Middle { get; set; }

        /// <summary>
        /// The user's last name.
        /// Truncated after the first 35 characters.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Required Last"),
         StringLength(35, ErrorMessage = Identifier + " - Last cannot exceed 35 characters")]
        public string Last { get; set; }
    }
}