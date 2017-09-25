using WePayApi.Shared;

namespace WePayApi.Report.Common
{
    /// <summary>
    /// All possible report types
    /// </summary>
    public class ReportTypes : WePayValues<ReportTypes>
    {
        public enum Choices : int
        {
            MerchantTransactions,
            Reconciliation
        }

        public const string MerchantTransactions = "merchant_transactions";
        public const string Reconciliation = "reconciliation";
    }
}