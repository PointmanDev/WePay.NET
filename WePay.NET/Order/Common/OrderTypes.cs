using WePayApi.Shared;

namespace WePayApi.Order.Common
{
    /// <summary>
    /// All possible Order Types currently recognized by WePay
    /// </summary>
    public class OrderTypes : WePayValues<OrderTypes>
    {
        public enum Choices : int
        {
            CardReader = 0
        }

        public const string CardReader = "card_reader";
    }
}