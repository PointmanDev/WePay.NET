using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class PartnerServiceRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.PartnerServiceRbitProperties";

        /// <summary>
        /// Not an API field, only use for validating requests, mainly for testing purposes
        /// </summary>
        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitTypeContainer;
            }
            set
            {
                RbitTypeContainer = Common.RbitTypes.PartnerService;
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
        public PartnerServiceRbitProperties ModulesUsed { get; set; }

        public PartnerServiceRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.PartnerService;
        }
    }
}