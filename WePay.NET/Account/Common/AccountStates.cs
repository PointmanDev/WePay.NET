using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Account.Common
{
    /// <summary>
    /// All possible account states
    /// </summary>
    public static class AccountStates
    {
        /// <summary>
        /// Indices for the Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            ActionRequired,
            Pending,
            Active,
            Disabled,
            Deleted
        }

        /// <summary>
        /// The account is not active and requires some action to be taken by the account owner.
        /// </summary>
        public const string ActionRequired = "action_required";

        /// <summary>
        /// The account was created using a temporary access token and needs to be confirmed by the account owner.
        /// </summary>
        public const string Pending = "pending";

        /// <summary>
        /// The account is active and no further action is required.
        /// </summary>
        public const string Active = "active";

        /// <summary>
        /// 	The account has been disabled by WePay and can no longer accept payments.
        /// 	An account will become disabled exactly 30 days after the first payment if no Know Your Customer (KYC) or settlement information is on file.
        /// 	WePay may also disable the account for security or regulatory reasons.
        /// </summary>
        public const string Disabled = "disabled";

        /// <summary>
        /// The account has been deleted.
        /// </summary>
        public const string Deleted = "deleted";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AccountStates()
        {
            WePayValues.FillValuesList(typeof(AccountStates), Values);
        }
    }
}