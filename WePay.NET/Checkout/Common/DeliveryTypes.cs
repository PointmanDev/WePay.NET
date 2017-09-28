using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Checkout.Common
{
    /// <summary>
    /// All possible delivery types
    /// </summary>
    public static class DeliveryTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
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

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static DeliveryTypes()
        {
            WePayValues.FillValuesList(typeof(DeliveryTypes), Values);
        }
    }
}