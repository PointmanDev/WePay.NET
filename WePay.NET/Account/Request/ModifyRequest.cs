using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Account.Response;
using WePayApi.Account.Structure;
using WePayApi.Risk.Structure.Rbit;
using WePayApi.Shared;
using WePayApi.Shared.Structure;

namespace WePayApi.Account.Request
{
    public class ModifyRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Request.ModifyRequest";

        /// <summary>
        /// The unique ID of the account you want to modify.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The name for the account. For security reasons, the word wepay cannot be in the account name.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The description for the account.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - Description cannot exceed 65535 characters")]
        public string Description { get; set; }

        /// <summary>
        /// The reference ID for the account. Can be any string, but must be unique for the account.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - ReferenceId cannot exceed 255 characters")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The URI that will receive IPNs for this account. You will receive an IPN whenever the account is verified or deleted.
        /// See the Instant Payment Notifications reference page (https://www.wepay.com/developer/reference/ipn) for more information.
        /// /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }

        /// <summary>
        /// Array of rbit structures associated with the account.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
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
        /// The URI for an image that you want to use for the accounts icon.
        /// This image will be used in the co-branded checkout process.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - ImageUri cannot exceed 2083 characters")]
        public string ImageUri { get; set; }

        /// <summary>
        /// The array of Google Analytics domains to be associated with the account.
        /// An empty array will remove all the Google Analytics domains previously associated with the account.
        /// See the Google Analytics tutorial (https://www.wepay.com/developer/reference/analytics) for more details.
        /// </summary>
        public string[] GaqDomains { get; set; }

        /// <summary>
        /// The theme structure you want to be used for the account's flows and emails.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Theme ThemeObject { get; set; }
    }
}