using System.Collections.Generic;
using WePay.Shared;

namespace WePay.AccountMembership.Common
{
    /// <summary>
    /// All possible roles
    /// </summary>
    public static class Roles
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Moderator,
            Admin,
            Member
        }

        /// <summary>
        /// Permits the user to make any changes to the account besides viewing or changing KYC and banking info.
        /// </summary>
        public const string Moderator = "moderator";

        /// <summary>
        /// The financial owner and may access and edit all information.
        /// </summary>
        public const string Admin = "admin";

        /// <summary>
        /// View-only privileges.
        /// </summary>
        public const string Member = "member";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Roles()
        {
            WePayValues.FillValuesList(typeof(Roles), Values);
        }
    }
}