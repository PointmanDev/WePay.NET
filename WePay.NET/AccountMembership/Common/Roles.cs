using WePayApi.Shared;

namespace WePayApi.AccountMembership.Common
{
    /// <summary>
    /// All possible roles
    /// </summary>
    public class Roles : WePayValues<Roles>
    {
        public enum Indices : int
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
    }
}