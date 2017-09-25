using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Common
{
    public class KnowYourCustomerStates : WePayValues<KnowYourCustomerStates>
    {
        public enum Choices : int
        {
            Unsubmitted,
            Unverified,
            RequireDocs,
            InReview,
            Verified
        }

        public const string Unsubmitted = "unsubmitted";
        public const string Unverified = "unverified";
        public const string RequireDocs = "require_docs";
        public const string InReview = "in_review";
        public const string Verified = "verified";
    }
}