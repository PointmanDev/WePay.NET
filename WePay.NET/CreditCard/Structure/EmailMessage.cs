using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Checkout.Structure
{
    /// <summary>
    /// Specifies a short message to send to the payee and payer when a checkout is successful.
    /// </summary>
    public class EmailMessage
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Structure.EmailMessage";

        /// <summary>
        /// A short message that will be included in the payment confirmation email to the payee.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - ToPayee cannot exceed 65535 characters")]
        public string ToPayee { get; set; }

        /// <summary>
        /// A short message that will be included in the payment confirmation email to the payer.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - ToPayer cannot exceed 65535 characters")]
        public string ToPayer { get; set; }
    }
}