using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.CreditCard.Common
{
    /// <summary>
    /// All possible Credit Card states recognized by WePay
    /// </summary>
    public static class CreditCardStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            New,
            Authorized,
            Expired,
            Deleted,
            Invalid
        }

        /// <summary>
        /// The credit card was just created by the application.
        /// </summary>
        public const string New = "new";

        /// <summary>
        /// The credit card was authorized either with an immediate charge or the CreditCard Authorize call.
        /// You can use the CreditCardId to charge this card in the future.
        /// </summary>
        public const string Authorzied = "authorized";

        /// <summary>
        /// The credit card was created but you did not charge the card or call CreditCard Authorize within 30 minutes.
        /// </summary>
        public const string Expired = "expired";

        /// <summary>
        /// The credit card was deleted or there was a failed credit card authorization attempt.
        /// </summary>
        public const string Deleted = "deleted";

        /// <summary>
        /// You tried to charge the card but the response we received indicated that the card is completely invalid and can never be charged
        /// (e.g., AVS mismatch, also known as a billing address check failure).
        /// </summary>
        public const string Invalid = "invalid";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static CreditCardStates()
        {
            WePayValues.FillValuesList(typeof(CreditCardStates), Values);
        }
    }
}