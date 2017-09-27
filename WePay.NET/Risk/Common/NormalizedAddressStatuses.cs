using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Normalized Address Statuses currently supported by WePay
    /// </summary>
    public static class NormalizedAddressStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            UserConfirmed,
            UserDenied,
            UserDidNotReview
        }

        /// <summary>
        /// User reviewed and confirmed normalized address as correct
        /// </summary>
        public const string UserConfirmed = "user_confirmed";

        /// <summary>
        /// User reviewed and indicated normalized address is not correct
        /// </summary>
        public const string UserDenied = "user_denied";

        /// <summary>
        /// User was not shown the normalized address and asked to confirm or deny
        /// </summary>
        public const string UserDidNotReview = "user_did_not_review";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static NormalizedAddressStatuses()
        {
            WePayValues.FillValuesList(typeof(NormalizedAddressStatuses), Values);
        }
    }
}