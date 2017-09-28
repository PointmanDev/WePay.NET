using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Account.Common
{
    /// <summary>
    /// All possible account types
    /// </summary>
    public static class AccountTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Nonprofit,
            Business,
            Personal
        }

        public const string Nonproft = "nonprofit";
        public const string Business = "business";
        public const string Personal = "personal";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AccountTypes()
        {
            WePayValues.FillValuesList(typeof(AccountTypes), Values);
        }
    }
}