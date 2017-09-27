using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.KnowYourCustomer.Common
{
    /// <summary>
    /// All possible Know Your Customer States currently supported by WePay
    /// </summary>
    public static class KnowYourCustomerStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
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

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static KnowYourCustomerStates()
        {
            WePayValues.FillValuesList(typeof(KnowYourCustomerStates), Values);
        }
    }
}