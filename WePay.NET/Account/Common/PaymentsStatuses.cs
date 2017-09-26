using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All Incoming and Outgoing Payments statuses
    /// </summary>
    public static class PaymentsStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Indices : int
        {
            Ok,
            Paused
        }

        public const string Ok = "ok";
        public const string Paused = "paused";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PaymentsStatuses()
        {
            WePayValues.FillValuesList(typeof(PaymentsStatuses), Values);
        }
    }
}