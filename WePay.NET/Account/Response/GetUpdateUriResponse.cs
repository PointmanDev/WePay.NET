namespace WePayApi.Account.Response
{
    public class GetUpdateUriResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The ID of the account that is updated by the URI.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The URI to add or update info for the specified account ID.
        /// Do not store the returned URI on your side as it can change.
        /// </summary>
        public string Uri { get; set; }
    }
}