using System.Collections.Generic;

namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible bank account types currently supported by WePay
    /// </summary>
    public static class BankAccountTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Checking,
            Savings
        }

        public const string Checking = "checking";
        public const string Savings = "savings";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static BankAccountTypes()
        {
            WePayValues.FillValuesList(typeof(BankAccountTypes), Values);
        }
    }
}