using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Creators for an AutoBilling Rbit
    /// </summary>
    public static class AutoBillingCreators
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Payer,
            Merchant
        }

        /// <summary>
        /// The payer set up and authorized auto-billing
        /// </summary>
        public const string Payer = "payer";

        /// <summary>
        /// The merchant set-up auto-billing on the payer's behalf
        /// </summary>
        public const string Merchant = "merchant";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AutoBillingCreators()
        {
            WePayValues.FillValuesList(typeof(AutoBillingCreators), Values);
        }
    }
}