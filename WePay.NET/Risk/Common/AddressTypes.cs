using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All Address Types currently supported by WePay
    /// </summary>
    public static class AddressTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
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

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static AddressTypes()
        {
            WePayValues.FillValuesList(typeof(AddressTypes), Values);
        }
    }
}