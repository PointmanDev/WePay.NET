using WePayApi.Shared;

namespace WePayApi.Order.Common
{
    /// <summary>
    /// All possible statuses for tracking information pertaining to a given order
    /// </summary>
    public class TrackingInformationStatuses : WePayValues<TrackingInformationStatuses>
    {
        public enum Choices : int
        {
            Shipped,
            Delivered,
            Returned
        }

        public const string Shipped = "shipped";
        public const string Delivered = "delivered";
        public const string Returned = "returned";
    }
}
