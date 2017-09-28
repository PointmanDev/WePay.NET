using WePay.Account.Structure;
using WePay.Shared.Structure;

namespace WePay.Account.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the account.
        /// </summary>
        public long? AccountId { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The state of the account.
        /// (Enumeration of these values can be found in WePay.Account.Common.AccountStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The account description. This information is used by the WePay Risk and Support teams.
        /// The description should provide a clear explanation of the purpose and use of the account.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique ID of the user who is the current financial owner of this account.
        /// </summary>
        public long? OwnerUserId { get; set; }

        /// <summary>
        /// The unique reference ID of the account (this is set by the application in the Create or Modify call).
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// The URI that will receive IPNs for this account.
        /// You will receive an IPN whenever the account is verified or deleted. If not present,
        /// then this value is not set for the account.
        /// </summary>
        public string CallbackUri { get; set; }

        /// <summary>
        /// The account type.
        /// (Enumeration of these values can be found in WePay.Account.Common.AccountTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) when the account was created.
        /// </summary>
        public long? CreateTime { get; set; }

        /// <summary>
        /// Array of account balances for each currency.
        /// </summary>
        public Balances[] Balances { get; set; }

        /// <summary>
        /// Array of incoming and outgoing payments status for each currency.
        /// </summary>
        public AccountCurrencyStatus[] Statuses { get; set; }

        /// <summary>
        /// Array of action strings explaining all the actions that are required to make this account active.
        /// It will be empty if no action is required.
        /// (Enumeration of these values can be found in WePay.Account.Common.ActionReasons)
        /// </summary>
        public string[] ActionReasons { get; set; }

        /// <summary>
        /// Array of strings explaining all reasons for why an account was disabled. It will be empty if the account is enabled.
        /// (Enumeration of these values can be found in WePay.Account.Common.DisabledReasons)
        /// </summary>
        public string[] DisabledReasons { get; set; }

        /// <summary>
        /// For accounts that have not provided Know Your Customer (KYC) and settlement information, this is the Unix timestamp (UTC) when the account will be disabled.
        /// If null then the account is valid and not scheduled to be disabled.
        /// </summary>
        public long? DisablementTime { get; set; }

        /// <summary>
        /// The account's country of origin 2-letter ISO code
        /// (Enumeration of these values can be found in WePay.Shared.Common.Countries)
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Array of supported currency strings for this account. Only one currency is allowed per account at this time.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        public string[] Currencies { get; set; }

        /// <summary>
        /// Array of rbits ids associated with the account.
        /// </summary>
        public string[] RbitsIds { get; set; }

        /// <summary>
        /// The account's fee schedule value.
        /// If not present, then this value has not been set for the account.
        /// PERMISSION REQUIRED
        /// </summary>
        public FeeSchedule[] FeeSchedule { get; set; }

        /// <summary>
        /// Array of supported card type strings for this account.
        /// (Enumeration of these values can be found in WePay.Account.Common.SupportedCardTypes)
        /// </summary>
        public string[] SupportedCardTypes { get; set; }

        /// <summary>
        /// The merchant's public-facing support contact number.
        /// If set, this phone number will be present on the payer's credit card statement.
        /// </summary>
        public InternationalPhoneNumber SupportContactNumber { get; set; }

        /// <summary>
        /// The URI for an image that you want to use for the accounts icon.
        /// This image will be used in the co-branded checkout process.
        /// </summary>
        public string Imageuri { get; set; }

        /// <summary>
        /// An array of Google Analytics domains associated with the account.
        /// See the analytics tutorial (https://www.wepay.com/developer/reference/analytics) for more information.
        /// </summary>
        public string[] GaqDomains { get; set; }

        /// <summary>
        /// The theme structure you want to be used for the account's flows and emails.
        /// </summary>
        public Theme ThemeObject { get; set; }
    }
}