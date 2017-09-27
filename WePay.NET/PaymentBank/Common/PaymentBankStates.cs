using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.PaymentBank.Common
{
    /// <summary>
    /// All possible Payment Bank States currently recognized by WePay
    /// </summary>
    public static class PaymentBankStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            New,
            Pending,
            Authorized,
            Disabled
        }

        /// <summary>
        /// The payment bank was just created by the application.
        /// </summary>
        public const string New = "new";

        /// <summary>
        /// The payment bank is being authorized for use with a checkout.
        /// If a user goes through the manual account entry flow during tokenization, we send deposits to their account and ask them to confirm them.
        /// </summary>
        public const string Pending = "pending";

        /// <summary>
        /// The payment bank is authorized for use with a checkout.
        /// </summary>
        public const string Authorized = "authorized";

        /// <summary>
        /// The payment bank has been disabled.
        /// </summary>
        public const string Disabled = "disabled";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PaymentBankStates()
        {
            WePayValues.FillValuesList(typeof(PaymentBankStates), Values);
        }
    }
}