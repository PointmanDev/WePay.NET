using WePayApi.Shared;

namespace WePayApi.Report.Common
{
    /// <summary>
    /// All possible object types
    /// </summary>
     public class ObjectTypes : WePayValues<ObjectTypes>
    {
        public enum Choices : int
        {
            Account,
            Withdrawal
        }

        public const string Account = "account";
        public const string Withdrawal = "withdrawal";
    }
}