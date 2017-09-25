using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All possible checkout types
    /// </summary>
    public class CheckoutTypes : WePayValues<CheckoutTypes>
    {
        public enum Choices : int
        {
            Goods,
            Service,
            Donation,
            Event,
            Personal
        }

        public const string Goods = "goods";
        public const string Service = "service";
        public const string Donation = "donation";
        public const string Event = "event";
        public const string Personal = "personal";
    }
}