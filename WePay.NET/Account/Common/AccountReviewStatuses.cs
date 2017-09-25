using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All possible account review statuses
    /// </summary>
    public class AccountReviewStatuses : WePayValues<AccountReviewStatuses>
    {
        public enum Choices : int
        {
            NotRequested,
            Pending,
            ReviewOk
        }

        public const string NotRequested = "not_requested";
        public const string Pending = "pending";
        public const string ReviewOk = "review_ok";
    }
}