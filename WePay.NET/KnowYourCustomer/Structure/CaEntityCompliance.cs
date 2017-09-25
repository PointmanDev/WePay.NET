using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// This structure is used for Canadian entities only.
    /// </summary>
    public class CaEntityCompliance
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.CaEntityCompliance";

        /// <summary>
        /// The GST/HST number used to validate a legal business or nonprofit organization in Canada.
        /// This field is required for businesses and nonprofit organizations.
        /// This field is optional for individuals.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires GstHst"),
         StringLength(255, ErrorMessage = Identifier + " - GstHst cannot exceed 255 characters")]
        public string GstHst { get; set; }
    }
}