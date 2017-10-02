using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class IndustryCodeRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.IndustryCodeRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.IndustryCode;
            }
        }

        /// <summary>
        /// The Industry Code Type
        /// (Enumeration of these values can be found in WePay.Risk.Common.IndustryCodeTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.IndustryCodeTypes")]
        public string IndustryCodeType { get; set; }

        /// <summary>
        /// The industry code for the IndustryType set. Either the Mcc, Sic, or Naics industry code.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires IndustryCode"),
         StringLength(32, ErrorMessage = Identifier + " - IndustryCode cannot exceed 32 characters")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// Additional text describing the industry code.
        /// For example, this may be category or actual drop-down text selected by the end user that maps to a particular industry code.
        /// </summary>
        [StringLength(1023, ErrorMessage = Identifier + " - IndustryDetail cannot exceed 1023 characters")]
        public string IndustryDetail { get; set; }

        public IndustryCodeRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.IndustryCode;
        }
    }
}