using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Order.Response;
using WePay.Shared.Structure;
using WePay.Order.Structure;

namespace WePay.Order.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Order.Request.CreateRequest";

        /// <summary>
        /// The merchant account to be associated with this order.
        /// KYC must be complete before the reader can be ordered.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The quantity of card readers for this order.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The type of order.
        /// (Enumeration of these values can be found in WePay.Order.Common.OrderTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Order.Common.OrderTypes")]
        public string Type { get; set; }

        /// <summary>
        /// Details of the order, for use when type equals CardReader
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public CardReader CardReader { get; set; }

        /// <summary>
        /// The allowed values will be defined in discussion with WePay.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ShippingMethod"),
         StringLength(255, ErrorMessage = Identifier + " - ShippingMethod cannot exceed 255 characters")]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Shipping contact details
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public ShippingContact ShippingContact { get; set; }

        /// <summary>
        /// Shipping ddress details
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// The URL that we will POST IPN data to.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }
    }
}