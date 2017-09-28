using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;
using WePay.Shared;
using WePay.Shared.Structure;
using WePay.Account.Structure;
using WePay.Risk.Structure.Rbit;

namespace WePay.Account.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.CreateRequest";

        /// <summary>
        /// The name for the account being created. For security reasons, the word wepay cannot be in the account name. 
        /// Note: Account names cannot contain control characters or non-printable characters, like emojis.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Name"),
         StringLength(255, ErrorMessage = "WePay.Account.Request.CreateRequest - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The description of the account you want to create.
        /// Describe the account in terms of: goods or services paid for using this account, types of payees, purpose of the account, etc.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Description"),
         StringLength(65535, ErrorMessage = Identifier + " - Description cannot exceed 65535 characters")]
        public string Description { get; set; }

        /// <summary>
        /// The reference ID of the account. It can be any string, but must be unique for the account.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The type of account you are creating.
        /// (Enumeration of these values can be found in WePay.Account.Common.AccountTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Account.Common.AccountTypes")]
        public string Type { get; set; }

        /// <summary>
        /// The URI that will receive IPNs for this account.
        /// If you set this parameter, you will receive an IPN whenever the account is verified or deleted.
        /// Otherwise, no notifications will be sent.
        /// See the Instant Payment Notifications page (https://www.wepay.com/developer/reference/ipn) for more information.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) indicating the merchant's type of business. See the MCC reference page (https://www.wepay.com/developer/reference/mcc) for more information.
        /// </summary>
        [StringLength(4, ErrorMessage = Identifier + " - Mcc cannot exceed 4 characters")]
        public string Mcc { get; set; }

        /// <summary>
        /// The account's country of origin 2-letter ISO code.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Countries)
        /// Default: US
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Countries")]
        public string Country { get; set; }

        /// <summary>
        /// Array of supported currency strings for this account.
        /// WePay currently supports only one currency per account.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// Default: USD
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string[] Currencies { get; set; }

        /// <summary>
        /// Array of rbit structures associated with the account.
        /// </summary>
        public Rbit[] Rbits { get; set; }

        /// <summary>
        /// Used for Canadian accounts only.
        /// Default: null
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CountryOptions CountryOptions { get; set; }

        /// <summary>
        /// The custom fee schedule value to use for the merchant.
        /// Values start at 0, not 1.
        /// Passing null will remove the custom fee schedule.
        /// PERMISSION REQUIRED
        /// </summary>
        public long? FeeScheduleSlot { get; set; }

        /// <summary>
        /// The merchant's public-facing support contact number.
        /// If set, this phone number will be present on the payer's credit card statement.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public InternationalPhoneNumber SupportContactNumber { get; set; }

        /// <summary>
        /// The theme structure you want to be used for the account's flows and emails
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Theme ThemeObject { get; set; }

        /// <summary>
        /// The URI for an image that you want to use for the accounts icon.
        /// This image will be used in the co-branded checkout process.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - ImageUri cannot exceed 2083 characters")]
        public string ImageUri { get; set; }

        /// <summary>
        /// An array of Google Analytics domains associated with the account.
        /// See the Google Analytics tutorial (https://www.wepay.com/developer/reference/analytics) for more details.
        /// </summary>
        public string[] GaqDomains { get; set; }
    }
}