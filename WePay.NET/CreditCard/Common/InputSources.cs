using WePayApi.Shared;

namespace WePayApi.CreditCard.Common
{
    public class InputSources : WePayValues<InputSources>
    {
        /// <summary>
        /// All possible methods of accepting CreditCard information
        /// </summary>
        public enum Choices : int
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
    }
}