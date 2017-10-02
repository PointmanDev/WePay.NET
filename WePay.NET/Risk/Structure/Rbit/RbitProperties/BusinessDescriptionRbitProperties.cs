using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class BusinessDescriptionRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.BusinessDescriptionRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.BusinessDescription;
            }
        }

        /// <summary>
        /// Text description of the business.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires BusinessDescription"),
         StringLength(10000, ErrorMessage = Identifier + " - BusinessDescription cannot exceed 10000 characters")]
        public string BusinessDescription { get; set; }

        /// <summary>
        /// Number of employees employed by the business.
        /// </summary>
        public int? NumberOfEmployees { get; set; }

        /// <summary>
        /// true: indicates that this merchant collects sales tax for each transaction
        /// false: indicates that this merchant does not collect sales tax for each transaction
        /// </summary>
        public bool? SalesTaxLiabilityFlag { get; set; }

        public BusinessDescriptionRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.BusinessDescription;
        }
    }
}