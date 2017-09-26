namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All countries currently supported by WePay
    /// </summary>
    public class Countries : WePayValues<Countries>
    {
        public enum Indices : int
        {
            US,
            CA,
            GB
        }

        /// <summary>
        /// United States
        /// </summary>
        public const string US = "US";

        /// <summary>
        /// Canada
        /// </summary>
        public const string CA = "CA";

        /// <summary>
        /// Great Britain
        /// </summary>
        public const string GB = "GB";
    }
}