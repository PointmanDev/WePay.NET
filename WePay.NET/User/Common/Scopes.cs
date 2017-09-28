using System.Collections.Generic;
using System.Reflection;
using WePay.Shared;

namespace WePay.User.Common
{
    /// <summary>
    /// All possible Scopes currently recognized by WePay (PROTIP: These are just permissions a user can hold)
    /// </summary>
    public static class Scopes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            ManageAccounts,
            CollectPayments,
            ViewUser,
            PreApprovePayments,
            SendMoney
        }

        public const string ManageAccounts = "manage_accounts";
        public const string CollectPayments = "collect_payments";
        public const string ViewUser = "view_user";
        public const string PreApprovePayments = "preapprove_payments";
        public const string SendMoney = "send_money";

        /// <summary>
        /// Produces comma separated list of all scopes
        /// </summary>
        /// <returns></returns>
        public static string AllowAllScopes()
        {
            string scopes = "";

            foreach (var p in typeof(Scopes).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                var value = p.GetValue(null);
                scopes += (string)value + ",";
            }

            return scopes.Substring(0, scopes.Length - 1);
        }

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Scopes()
        {
            WePayValues.FillValuesList(typeof(Scopes), Values);
        }
    }
}