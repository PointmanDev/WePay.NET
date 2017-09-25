using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Risk.Structure
{
    /// <summary>
    /// Contains details about a shipment of goods or services.
    /// </summary>
    public class ShippingInfo
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.ShippingInfo";

        /// <summary>
        /// The Unix timestamp when goods or services are expected to be delivered (seconds since Jan 1st 1970 UTC).
        /// </summary>
        public long? ExpectedDeliveryTime { get; set; }

        /// <summary>
        /// The Unix timestamp when goods have been shipped (seconds since Jan 1st 1970 UTC).
        /// </summary>
        public long? ShippingTime { get; set; }

        /// <summary>
        /// The shipping carrier (USPS, FEDEX, etc).
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Carrier cannot exceed 255 characters")]
        public string Carrier { get; set; }

        /// <summary>
        /// The tracking number for the shipping carrier.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - TrackingNumber cannot exceed 255 characters")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The URL for the tracking information.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - TrackingUrl cannot exceed 2083 characters")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// The Unix timestamp when goods or services were actually delivered (seconds since Jan 1st 1970 UTC).
        /// </summary>
        public long? ActualDeliveryTime { get; set; }
    }
}