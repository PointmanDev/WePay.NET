using WePayApi.Shared;

namespace WePayApi.User.Common
{
    // All possible User Types currently recognized by WePay
    public class UserTypes : WePayValues<UserTypes>
    {
        public enum Indices : int
        {
            Sso
        }

        /// <summary>
        /// To create an SSO user, set the value to sso.
        /// </summary>
        public const string Sso = "sso";
    }
}