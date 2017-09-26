using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All possible account types
    /// </summary>
    public static class AccountTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Indices : int
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