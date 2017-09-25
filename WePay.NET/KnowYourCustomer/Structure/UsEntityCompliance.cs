using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// This structure is used for U.S. entities only.
    /// </summary>
    public class UsEntityCompliance
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.UsEntityCompliance";

        /// <summary>
        /// The EIN used to validate a legal business or nonprofit organization in the US.
        /// This field is required for businesses and nonprofit organizations.
        /// This field is optional for individuals.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Ein"),
         StringLength(255, ErrorMessage = Identifier + " - Ein cannot exceed 255 characters")]
        public string Ein { get; set; }
    }
}