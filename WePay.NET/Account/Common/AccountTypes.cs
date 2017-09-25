using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All possible account types
    /// </summary>
    public class AccountTypes : WePayValues<AccountTypes>
    {
        public enum Choices : int
        {
            Nonprofit,
            Business,
            Personal
        }

        public const string Nonproft = "nonprofit";
        public const string Business = "business";
        public const string Personal = "personal";
    }
}