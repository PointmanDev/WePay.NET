using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All actions that are required to make this account active
    /// </summary>
    public static class ActionReasons
    {
        /// <summary>
        /// Indices for Values property for iterations
        /// </summary>
        public enum ValuesIndices : int
        {
            BankAccount,
            Kyc,
            Document
        }

        public const string BankAccount = "bank_account";
        public const string Kyc = "kyc";
        public const string Document = "document";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static ActionReasons()
        {
            WePayValues.FillValuesList(typeof(ActionReasons), Values);
        }
    }
}