using System.Reflection;
using WePayApi.Shared;

namespace WePayApi.User.Common
{
    /// <summary>
    /// All possible Scopes currently recognized by WePay (PROTIP: These are just permissions a user can hold)
    /// </summary>
    public class Scopes : WePayValues<Scopes>
    {
        public enum Indices : int
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
    }
}