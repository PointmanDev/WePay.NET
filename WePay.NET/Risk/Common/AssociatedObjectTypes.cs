using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All possible WePay types for which an Rbit can be associated with
    /// </summary>
    public static class AssociatedObjectTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Account,
            User,
            Checkout,
            Preapproval,
            CreditCard
        }

        /// <summary>
        /// For information about a payee.
        /// </summary>
        public const string Account = "account";

        /// <summary>
        /// For information about a payer with a WePay user id.
        /// </summary>
        public const string User = "user";

        /// <summary>
        /// For information about a checkout transaction or checkout payer.
        /// </summary>
        public const string Checkout = "checkout";

        /// <summary>
        /// For information about a preapproval transaction or preapproval payer.
        /// </summary>
        public const string Preapproval = "preapproval";

        /// <summary>
        /// For information about the owner of a credit card.
        /// </summary>
        public const string CreditCard = "credit_card";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AssociatedObjectTypes()
        {
            WePayValues.FillValuesList(typeof(AssociatedObjectTypes), Values);
        }
    }
}