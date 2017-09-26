using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All Address Types currently supported by WePay
    /// </summary>
    public class AddressTypes : WePayValues<AddressTypes>
    {
        public enum Indices : int
        {
            Incorporation,
            Headquarters,
            Satellite,
            MailForwarding,
            Home
        }

        /// <summary>
        /// Address associated with business' incorporation
        /// </summary>
        public const string Incorporation = "incorporation";

        /// <summary>
        /// Main office
        /// </summary>
        public const string Headquarters = "headquarters";

        /// <summary>
        /// A non-headquarters office
        /// </summary>
        public const string Satellite = "satellite";

        /// <summary>
        /// Address used to receive mail
        /// </summary>
        public const string MailForwarding = "mail_forwarding";

        /// <summary>
        /// A person's home address
        /// </summary>
        public const string Home = "home";
    }
}