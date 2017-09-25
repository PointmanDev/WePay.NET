using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All possible delivery types
    /// </summary>
    public class DeliveryTypes : WePayValues<DeliveryTypes>
    {
        public enum Choices : int
        {
            None,
            FullyDelivered,
            PointOfSale,
            Shipping,
            Donation,
            Subscription,
            PartialPrepayment,
            FullPrepayment
        }

        public const string None = "none";
        public const string FullyDelivered = "fully_delivered";
        public const string PointOfSale = "point_of_sale";
        public const string Shipping = "shipping";
        public const string Donation = "donation";
        public const string Subscription = " subscription";
        public const string PartialPrepayment = "partial_prepayment";
        public const string FullPrepayment = "full_prepayment";
    }
}