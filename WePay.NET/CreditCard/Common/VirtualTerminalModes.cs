using WePayApi.Shared;

namespace WePayApi.CreditCard.Common
{
    public class VirtualTerminalModes : WePayValues<VirtualTerminalModes>
    {
        /// <summary>
        /// All possible virtual terminal modes
        /// </summary>
        public enum Indices : int
        {
            Mobile,
            Web,
            None
        }

        public const string Mobile = "mobile";
        public const string Web = "web";
        public const string None = "none";
    }
}