using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class BusinessNameRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.BusinessNameRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.BusinessName;
            }
        }

        /// <summary>
        /// The full name of the business.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires BusinessName"),
         StringLength(255, ErrorMessage = Identifier + " - BusinessName cannot exceed 255 characters")]
        public string BusinessName { get; set; }

        /// <summary>
        /// The kind of name used for the business.
        /// (Enumeration of these values can be found in WePay.Risk.Common.BusinessNameTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.BusinessNameTypes")]
        public string NameType { get; set; }

        public BusinessNameRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.BusinessName;
        }
    }
}