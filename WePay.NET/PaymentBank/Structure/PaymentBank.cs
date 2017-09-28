using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.PaymentBank.Structure
{
    /// <summary>
    /// The payment bank structure object contains the unique ID for a payment bank.
    /// </summary>
    public class PaymentBank
    {
        [JsonIgnore]
        private const string Identifier = "WePay.PaymentBank.Structure.PaymentBank";

        /// <summary>
        /// The payment bank ID.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Id")]
        public long? Id { get; set; }
    }
}