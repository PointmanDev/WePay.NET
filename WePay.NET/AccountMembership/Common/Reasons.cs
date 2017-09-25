using WePayApi.Shared;

namespace WePayApi.AccountMembership.Common
{
    /// <summary>
    /// All possible reasons for WePayApi.AccountMembership.Structure.AdminContext Reason field
    /// </summary>
    public class Reasons : WePayValues<Reasons>
    {
        public enum Choices
        {
            Beneficiary,
            OtherOrganizer,
            Other
        }

        public const string Beneficiary = "beneficiary";
        public const string OtherOrganizer = "other_organizer";
        public const string Other = "other";
    }
}