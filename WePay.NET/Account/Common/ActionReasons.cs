using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All actions that are required to make this account active
    /// </summary>
    public class ActionReasons : WePayValues<ActionReasons>
    {
        public enum Indices : int
        {
            BankAccount,
            Kyc,
            Document
        }

        public const string BankAccount = "bank_account";
        public const string Kyc = "kyc";
        public const string Document = "document";
    }
}