﻿using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Account.Common
{
    /// <summary>
    /// All Incoming and Outgoing Payments statuses
    /// </summary>
    public static class PaymentsStatuses
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
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