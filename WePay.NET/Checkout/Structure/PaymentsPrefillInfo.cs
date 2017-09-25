using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;

namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// Specifies prefill information for checkout, preapprovals, and subscription flows.
    /// </summary>
    public class PaymentsPrefillInfo
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Structure.PaymentsPrefillInfo";

        /// <summary>
        /// The name of the person.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The email address of the person.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the person.
        /// </summary>
        [StringLength(15, ErrorMessage = Identifier + " - PhoneNumber cannot exceed 15 characters")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The street address.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Address Address { get; set; }
    }
}