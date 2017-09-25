namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible bank account types currently supported by WePay
    /// </summary>
    public class BankAccountTypes : WePayValues<BankAccountTypes>
    {
        public enum Choices : int
        {
            Checking,
            Savings
        }

        public const string Checking = "checking";
        public const string Savings = "savings";
    }
}