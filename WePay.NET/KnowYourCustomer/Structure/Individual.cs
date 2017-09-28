using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.KnowYourCustomer.Structure
{
    /// <summary>
    /// The KYC Individual Structure contains information about an account owner who is an individual (as opposed to a business or an organization).
    /// </summary>
    public class Individual
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Structure.Individual";

        /// <summary>
        /// /The individual owner.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public AccountOwner AccountOwner { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) that specifies the industry associated with the business.
        /// See the MCC Page (https://www.wepay.com/developer/reference/mcc) for more information.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Mcc"),
         StringLength(255, ErrorMessage = Identifier + " - Mcc cannot exceed 255 characters")]
        public string Mcc { get; set; }

        /// <summary>
        /// The URL of the individual's website.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires PrimaryUrl"),
         StringLength(255, ErrorMessage = Identifier + " - PrimaryUrl cannot exceed 255 characters")]
        public string PrimaryUrl { get; set; }
    }
}