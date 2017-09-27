using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Report.Common
{
    /// <summary>
    /// All possible report types
    /// </summary>
    public static class ReportTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            MerchantTransactions,
            Reconciliation
        }

        public const string MerchantTransactions = "merchant_transactions";
        public const string Reconciliation = "reconciliation";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static ReportTypes()
        {
            WePayValues.FillValuesList(typeof(ReportTypes), Values);
        }
    }
}