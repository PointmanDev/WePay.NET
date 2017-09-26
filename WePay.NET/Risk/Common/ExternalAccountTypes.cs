using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible external account types currently supported by WePay
    /// </summary>
    public class ExternalAccountTypes : WePayValues<ExternalAccountTypes>
    {
        public enum Indices : int
        {
            Facebook,
            Linkedin,
            Klout,
            Twitter,
            Ebay,
            Googleplus,
            Yelp,
            Etsy
        }

        public const string Facebook = "facebook";
        public const string Linkedin = "linkedin";
        public const string Klout = "klout";
        public const string Twitter = "twitter";
        public const string Ebay = "ebay";
        public const string Googleplus = "googleplus";
        public const string Yelp = "yelp";
        public const string Etsy = "etsy";
    }
}