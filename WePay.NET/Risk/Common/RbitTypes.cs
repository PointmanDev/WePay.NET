using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible currently supported Rbit types
    /// </summary>
    public class RbitTypes : WePayValues<RbitTypes>
    {
        public enum Indices : int
        {
            Address,
            AutoBilling,
            BusinessDescription,
            BusinessName,
            Email,
            ExternalAccount,
            FundraisingEvent,
            IndustryCode,
            PartnerService,
            Person,
            Phone,
            TransactionDetails
        }

        /// <summary>
        /// A mailing address associated with a user or account.
        /// Rbits of type address should be sent either as a related rbit of type = person or as a top level rbit for an account.
        /// </summary>
        public const string Address = "address";

        /// <summary>
        /// If the transaction is set-up for auto-billing (where the users card is charged automatically every month), include this rbit to provide details of the auto-billing.
        /// </summary>
        public const string AutoBilling = "auto_billing";

        /// <summary>
        /// Rbts of type “business_description” should be sent as a top-level rbit for an account.
        /// </summary>
        public const string BusinessDescription = "business_description";

        /// <summary>
        /// The business name associated with an account.
        /// </summary>
        public const string BusinessName = "business_name";

        /// <summary>
        /// The email address associated with an entity.
        /// TIP: Usually passed in as a RelatedRbits of type = person.
        /// </summary>
        public const string Email = "email";

        /// <summary>
        /// The user’s external accounts, such as Facebook or Twitter.
        /// </summary>
        public const string ExternalAccount = "external_account";

        /// <summary>
        /// Information about an event that is the context for a donation transaction or donation account. It can therefore be passed as an rbit associated with a checkout or an account.
        /// </summary>
        public const string FundraisingEvent = "fundraising_event";

        /// <summary>
        /// A code from one of several sources that indicates the industry associated with the business.
        /// </summary>
        public const string IndustryCode = "industry_code";

        /// <summary>
        /// This type describes one type of service or product the user has signed up for on the partner site.
        /// This should be passed as a related rbit of the External Account rbit that contains partner site information.
        /// If the user is signed up for multiple services, you can pass multiple related rbits.
        /// </summary>
        public const string PartnerService = "partner_service";

        /// <summary>
        /// Information about a person associated with a user or account.
        /// It could be a person who does not have formal access to the User or Account
        /// (e.g., an employee of a company who provided information).
        /// Rbits of type Person are usually associated with the following related rbits: Phone and Address.
        /// </summary>
        public const string Person = "person";

        /// <summary>
        /// A phone number associated with a user or account.
        /// Rbits of type phone should be sent either as a related rbit of type = person or as a top level rbit for an account.
        /// </summary>
        public const string Phone = "phone";

        /// <summary>
        /// Information regarding a specific transaction.
        /// </summary>
        public const string TransactionDetails = "transaction_details";
    }
}