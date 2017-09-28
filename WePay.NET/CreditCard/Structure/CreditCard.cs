using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.CreditCard.Structure
{
    /// <summary>
    /// The Credit Card Structure object specifies the credit card ID used for tokenization.
    /// </summary>
    public class CreditCard
    {
        [JsonIgnore]
        private const string Identifier = "WePay.CreditCard.Structure.CreditCard";

        /// <summary>
        /// Credit card ID from CreditCard Create.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Structure for passing in additional credit card information.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CreditCardAdditionalData Data { get; set; }

        /// <summary>
        /// If present and set to false, the credit card will not be automatically charged (will only be authorized)
        /// and the associated Checkout will not progress past the state of 'Authorized' until a call to Checkout Capture is made,
        /// or if 7 days pass without having called Checkout Capture, the associated checkout will transition to state 'Cancelled'.
        /// Default: true
        /// </summary>
        public bool? AutoCapture { get; set; }
    }
}