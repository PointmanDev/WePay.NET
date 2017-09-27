using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    public static class PaymentFrequencies
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Weekly,
            Monthly,
            Quarterly,
            Annually
        }

        public const string Weekly = "weekly";
        public const string Monthly = "monthly";
        public const string Quarterly = "quarterly";
        public const string Annually = "annually";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PaymentFrequencies()
        {
            WePayValues.FillValuesList(typeof(PaymentFrequencies), Values);
        }
    }
}