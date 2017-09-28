using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains information used to identify a user in Canada.
    /// </summary>
    public class CaOwnerCompliance
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Structure.CaOwnerCompliance";

        /// <summary>
        /// The Social Insurance Number (SIN) number used to identify an individual in Canada.
        /// The SIN number must be of the form nnn-nnn-nnn and consist only of digits 0 through 9.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - SocialInsuranceNumber cannot exceed 255 characters"),
         RegularExpression(@"^\d{3}-?\d{3}-?\d{3}$", ErrorMessage = Identifier + " - SocialInsuranceNumber must be of the form nnn-nnn-nnn where n is a digit between 0 and 9")]
        public string SocialInsuranceNumber { get; set; }
    }
}