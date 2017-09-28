namespace WePay.Order.Structure
{
    /// <summary>
    /// The tracking information structure contains details on mPOS card reader shipments.
    /// It is only relevant to partners using WePay’s mPOS fulfillment service.
    /// </summary>
    public class TrackingInformation
    {
        /// <summary>
        /// The name of the service used for deliveries.
        /// </summary>
        public string TrackingService { get; set; }

        /// <summary>
        /// The tracking code provided by the delivery service.
        /// </summary>
        public string TrackingCode { get; set; }

        /// <summary>
        /// The status of the package.
        /// (Enumeration of these values can be found in WePay.Order.Common.TrackingInformationStatuses)
        /// </summary>
        public string Status { get; set; }
    }
}