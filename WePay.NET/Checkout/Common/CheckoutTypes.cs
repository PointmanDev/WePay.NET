using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All possible checkout types
    /// </summary>
    public static class CheckoutTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Indices : int
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

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static CheckoutTypes()
        {
            WePayValues.FillValuesList(typeof(CheckoutTypes), Values);
        }
    }
}