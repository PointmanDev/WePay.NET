using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All possible optionns for IsPartnerAccount field on ExternalAccountProperties (yes WePay made this a string not boolean value)
    /// </summary>
    public static class IsPartnerAccountOptions
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Yes,
            No
        }

        /// <summary>
        /// This is an account controlled by you, the WePay partner.
        /// </summary>
        public const string Yes = "yes";

        /// <summary>
        /// This is not an account controlled by you, the WePay partner.
        /// </summary>
        public const string No = "no";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static IsPartnerAccountOptions()
        {
            WePayValues.FillValuesList(typeof(IsPartnerAccountOptions), Values);
        }
    }
}