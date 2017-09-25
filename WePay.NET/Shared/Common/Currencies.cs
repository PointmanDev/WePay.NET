namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All currencies currently supported by WePay
    /// </summary>
    public class Currencies : WePayValues<Countries>
    {
        public enum Choices : int
        {
            USD,
            CAD,
            GBP
        }

        /// <summary>
        /// US Dollar
        /// </summary>
        public const string USD = "USD";

        /// <summary>
        /// Canadian Dollar
        /// </summary>
        public const string CAD = "CAD";

        /// <summary>
        /// Great British Pound
        /// </summary>
        public const string GBP = "GBP";
    }
}