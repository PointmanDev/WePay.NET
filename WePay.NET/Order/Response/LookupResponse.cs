using WePay.Order.Structure;
using WePay.Shared;
using WePay.Shared.Structure;

namespace WePay.Order.Response
{
    public class LookupResponse : WePayResponse
    {
        /// <summary>
        /// The unique ID of the order.
        /// </summary>
        public long? OrderId { get; set; }

        /// <summary>
        /// The merchant account associated with this order.
        /// KYC must be complete before the reader can be ordered.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The number of card readers that were ordered.
        /// </summary>
        public long? Quantity { get; set; }

        /// <summary>
        /// The status of the order.
        /// (Enumeration of these values can be found in WePay.Order.Common.OrderStatuses)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The type of order.
        /// (Enumeration of these values can be found in WePay.Order.Common.OrderTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Details of the order, for use when type equals CardReader
        /// </summary>
        public CardReader CardReader { get; set; }

        /// <summary>
        /// The allowed values will be defined in discussion with WePay.
        /// </summary>
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Shipping contact details
        /// </summary>
        public ShippingContact ShippingContact { get; set; }

        /// <summary>
        /// Shipping address details
        /// </summary>
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Tracking information
        /// </summary>
        public TrackingInformation[] TrackingInformation { get; set; }
    }
}