using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Account.Response;
using WePay.Shared;
using WePay.Account.Structure;

namespace WePay.Account.Request
{
    public class GetUpdateUriRequest : Shared.WePayRequest<GetUpdateUriResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Account.Request.GetUpdateUriRequest";

        /// <summary>
        /// The unique ID of the account you want to add or update info for.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// What mode the process will be displayed in.
        /// (Enumeration of these values can be found in WePay.Shared.Common.ProcessModes)
        /// The options are iframe or regular. Choose iframe if you would like to frame the process on your site.
        /// Default: regular
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.ProcessModes")]
        public string Mode { get; set; }

        /// <summary>
        /// The URI to which the user is be redirected to after completing the Know Your Customer (KYC) or settlement setup information input process.
        /// Default: null
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - RedirectUri cannot exceed 2083 characters")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Prefill the Know Your Customer (KYC) form with information that you already have about the merchant.
        /// PERMISSION REQUIRED
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public KycPrefillInfo PrefillInfo { get; set; }
    }
}