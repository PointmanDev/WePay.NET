using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Order.Structure
{
    /// <summary>
    /// The shipping contact structure contains information about the recipient of an mPOS card reader.
    /// It is only relevant to platforms using WePay’s mPOS service.
    /// </summary>
    public class ShippingContact
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Order.Structure.ShippingContact";

        /// <summary>
        /// The name of the contact for this order.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the company for this order (optional).
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Company cannot exceed 255 characters")]
        public string Company { get; set; }

        /// <summary>
        /// The phone number of the contact for this order.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Phone cannot exceed 255 characters")]
        public string Phone { get; set; }

        /// <summary>
        /// The email address of the contact for this order
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }
    }
}