using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Normalized Address Statuses currently supported by WePay
    /// </summary>
    public class NormalizedAddressStatuses : WePayValues<NormalizedAddressStatuses>
    {
        public enum Indices : int
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
    }
}