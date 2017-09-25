using WePayApi.KnowYourCustomer.Structure;

namespace WePayApi.KnowYourCustomer.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the account.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The state of KYC for the account.
        /// (Enumeration of these values can be found in WePayApi.KnowYourCustomer.Common.KnowYourCustomerStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Array of document structures that contains information about each individual document submitted by the user for verification.
        /// Note that not all accounts require documentation to complete KYC.
        /// </summary>
        public DocumentResponse[] DocumentResponse { get; set; }

        /// <summary>
        /// The legal name of the account owner.
        /// </summary>
        public Name LegalName { get; set; }
    }
}