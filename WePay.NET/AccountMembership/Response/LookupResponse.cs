namespace WePayApi.AccountMembership.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the account.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The unique ID of the user that was added, modified or removed.
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// The role assigned to the user.
        /// </summary>
        public string Role { get; set; }
    }
}