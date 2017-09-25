namespace WePayApi.KnowYourCustomer.Response
{
    public class CreateResponse : Shared.WePayResponse
    {
        /// <summary>
        /// A unique ID for the newly created KYC object.
        /// </summary>
        public long? KycId { get; set; }
    }
}