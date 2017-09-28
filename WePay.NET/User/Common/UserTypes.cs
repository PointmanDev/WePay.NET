using System.Collections.Generic;
using WePay.Shared;

namespace WePay.User.Common
{
    // All possible User Types currently recognized by WePay
    public static class UserTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Sso
        }

        /// <summary>
        /// To create an SSO user, set the value to sso.
        /// </summary>
        public const string Sso = "sso";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static UserTypes()
        {
            WePayValues.FillValuesList(typeof(UserTypes), Values);
        }
    }
}