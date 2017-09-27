using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Report.Common
{
    /// <summary>
    /// All possible object types
    /// </summary>
     public static class ObjectTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Account,
            Withdrawal
        }

        public const string Account = "account";
        public const string Withdrawal = "withdrawal";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static ObjectTypes()
        {
            WePayValues.FillValuesList(typeof(ObjectTypes), Values);
        }
    }
}