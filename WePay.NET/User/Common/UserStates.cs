using System.Collections.Generic;
using WePay.Shared;

namespace WePay.User.Common
{
    /// <summary>
    /// All possible UserStates currently recognized by WePay
    /// </summary>
    public static class UserStates
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Pending,
            Registered,
            Deleted
        }

        /// <summary>
        /// The user registered with User Register call and has not yet confirmed the registration using the link in the confirmation email
        /// A user whose registration is in a pending state is subject to limitations on the total amount funds
        /// they may accept and the period of time during which they may accept payments before their their account is deleted.
        /// </summary>
        public const string Pending = "pending";

        /// <summary>
        /// The user's registration on WePay is complete.
        /// When a user is first created, an email is sent to the email address supplied at the time of their registration with a confirmation link.
        /// The initial state (when the confirmation email is sent) is pending.
        /// When the WePay system receives the confirmation, the user's state is changed to registered.
        /// If the user is created using the User Register call,
        /// a subsequent User SendConfirmation call must be made in order to send the confirmation email.
        /// </summary>
        public const string Registered = "registered";

        /// <summary>
        /// The user's registration was deleted.
        /// A user may delete their account themselves, or an account may be deleted by WePay customer support.
        /// </summary>
        public const string Deleted = "deleted";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static UserStates()
        {
            WePayValues.FillValuesList(typeof(UserStates), Values);
        }
    }
}