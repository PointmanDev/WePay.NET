using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Phone Types currently supported by WePay
    /// </summary>
    public class PhoneTypes : WePayValues<PhoneTypes>
    {
        public enum Choices : int
        {
            Home,
            Mobile,
            Work
        }

        public const string Home = "home";
        public const string Mobile = "mobile";
        public const string Work = "work";
    }
}