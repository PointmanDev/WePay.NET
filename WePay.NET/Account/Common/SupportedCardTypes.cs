using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All possible supported card types currently supported by WePay
    /// </summary>
    public static class SupportedCardTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Indices : int
        {
            Visa = 0,
            Mastercard,
            AmericanExpress,
            Discover,
            Jcb,
            DinersClub
        }

        public const string Visa = "visa";
        public const string Mastercard = "mastercard";
        public const string AmericanExpress = "american_express";
        public const string Discover = "discover";
        public const string Jcb = "jcb";
        public const string DinersClub = "diners_club";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static SupportedCardTypes()
        {
            WePayValues.FillValuesList(typeof(SupportedCardTypes), Values);
        }
    }
}