using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible optionns for IsPartnerAccount field on ExternalAccountProperties (yes WePay made this a string not boolean value)
    /// </summary>
    public class IsPartnerAccountOptions : WePayValues<IsPartnerAccountOptions>
    {
        public enum Choices : int
        {
            Yes,
            No
        }

        /// <summary>
        /// This is an account controlled by you, the WePay partner.
        /// </summary>
        public const string Yes = "yes";

        /// <summary>
        /// This is not an account controlled by you, the WePay partner.
        /// </summary>
        public const string No = "no";
    }
}