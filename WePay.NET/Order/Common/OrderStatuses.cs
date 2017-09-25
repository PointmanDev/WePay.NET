using WePayApi.Shared;

namespace WePayApi.Order.Common
{
    /// <summary>
    /// All possible Order Statuses currently recognized by WePay
    /// </summary>
    public class OrderStatuses : WePayValues<OrderStatuses>
    {
        public enum Choices : int
        {
            Open,
            Processed,
            Failed
        }

        public const string Open = "open";
        public const string Processed = "processed";
        public const string Failed = "failed";
    }
}