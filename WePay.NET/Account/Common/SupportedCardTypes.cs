using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All possible supported card types currently supported by WePay
    /// </summary>
    public class SupportedCardTypes : WePayValues<SupportedCardTypes>
    {
        public enum Choices : int
        {
            Visa = 0,
            Mastercard,
            AmericanExpress,
            Discover,
            Jcb,
            DinersClub
        }

        public const string Visa = "visa";
        public const string Mastercard = "mastercard";
        public const string AmericanExpress = "american_express";
        public const string Discover = "discover";
        public const string Jcb = "jcb";
        public const string DinersClub = "diners_club";
    }
}