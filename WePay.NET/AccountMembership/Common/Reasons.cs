using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.AccountMembership.Common
{
    /// <summary>
    /// All possible reasons for WePayApi.AccountMembership.Structure.AdminContext Reason field
    /// </summary>
    public static class Reasons
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum Choices
        {
            Beneficiary,
            OtherOrganizer,
            Other
        }

        public const string Beneficiary = "beneficiary";
        public const string OtherOrganizer = "other_organizer";
        public const string Other = "other";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static Reasons()
        {
            WePayValues.FillValuesList(typeof(Reasons), Values);
        }
    }
}