using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Order.Structure
{
    /// <summary>
    /// The card reader structure contains details on orders for card readers placed using WePay’s mPOS fulfillment service.
    /// It is only relevant to platforms using WePay’s mPOS service.
    /// </summary>
    public class CardReader
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Order.Structure.CardReader";

        /// <summary>
        /// Model of card reader (valid options are defined as part of your integration with mPOS.)
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Model"),
         StringLength(255, ErrorMessage = Identifier + " - Model cannot exceed 255 characters")]
        public string Model { get; set; }
    }
}