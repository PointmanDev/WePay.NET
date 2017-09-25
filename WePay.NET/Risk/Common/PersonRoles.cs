using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible roles for which a person can have in the Person Rbit
    /// </summary>
    public class PersonRoles : WePayValues<PersonRoles>
    {
        public enum Choices : int
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
    }
}