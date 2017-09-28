using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// This type describes one type of service or product the user has signed up for on the partner site.
    /// This should be passed as a related rbit of the ExternalAccount rbit that contains partner site information.
    /// If the user is signed up for multiple services, you can pass multiple related rbits.
    /// </summary>
    public class PartnerServiceProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.PartnerServiceProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.Address;
            }
        }

        /// <summary>
        /// The name of the service or product the user has signed up for on the partner s site.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires ServiceName"),
         StringLength(1023, ErrorMessage = Identifier + " - ServiceName cannot exceed 1023 characters")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Monthly cost of the service.
        /// If billed annually, provide the average monthly amount.
        /// </summary>
        public double? ServiceMonthlyCost { get; set; }

        /// <summary>
        /// The currency used.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// Array of PartnerServices for each module the user has signed up for in the partner's site
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public PartnerServiceProperties ModulesUsed { get; set; }
    }
}