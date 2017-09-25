using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// Rbts of type 'BusinessDescription” should be sent as a top-level rbit for an account.
    /// </summary>
    public class BusinessDescriptionProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.Rbit.RbitProperties.BusinessDescriptionProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.BusinessDescription;
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
    }
}