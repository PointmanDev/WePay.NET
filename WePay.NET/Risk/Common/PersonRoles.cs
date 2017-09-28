using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Risk.Common
{
    /// <summary>
    /// All possible roles for which a person can have in the Person Rbit
    /// </summary>
    public static class PersonRoles
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            Employee,
            Fundraiser,
            FundraisingTeamCaptain,
            OtherThirdParty
        }

        public const string Employee = "employee";
        public const string Fundraiser = "fundraiser";
        public const string FundraisingTeamCaptain = "fundraising_team_captain";
        public const string OtherThirdParty = "other_third_party";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static PersonRoles()
        {
            WePayValues.FillValuesList(typeof(PersonRoles), Values);
        }
    }
}