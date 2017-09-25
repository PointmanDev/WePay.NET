using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Industry Code Types currently supported by WePay
    /// </summary>
    public class IndustryCodeTypes : WePayValues<IndustryCodeTypes>
    {
        public enum Choices : int
        {
            Mcc,
            Sic,
            Naics
        }

        public const string Mcc = "mcc";
        public const string Sic = "sic";
        public const string Naics = "naics";
    }
}