﻿using System.Collections.Generic;
using WePay.Shared;

namespace WePay.CreditCard.Common
{
    /// <summary>
    /// All possible methods of accepting CreditCard information
    /// </summary>
    public static class InputSources
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            CardKeyed,
            CardSwiped,
            CardTransfer,
            CardEmv,
            CardFallbackSwipe,
            CardFallbackKeyed,
            CardRecurring,
            ApplePay,
            AndroidPay
        }

        public const string CardKeyed = "card_keyed";
        public const string CardSwiped = "card_swiped";
        public const string CardTransfer = "card_transfer";
        public const string CardEmv = "card_emv";
        public const string CardFallbackSwipe = "card_fallback_swipe";
        public const string CardFallbackKeyed = "card_fallback_keyed";
        public const string CardRecurring = "card_recurring";
        public const string ApplePay = "apple_pay";
        public const string AndroidPay = "android_pay";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static InputSources()
        {
            WePayValues.FillValuesList(typeof(InputSources), Values);
        }
    }
}