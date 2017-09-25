namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible frequencies supported by WePay
    /// </summary>
    public class Frequencies : WePayValues<Frequencies>
    {
        public enum Choices : int
        {
            Daily,
            Weekly,
            Monthly
        }

        public const string Daily = "daily";
        public const string Weekly = "weekly";
        public const string Monthly = "monthly";
    }
}