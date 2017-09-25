using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;

namespace WePayApi.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// The business name associated with an account.
    /// </summary>
    public class BusinessNameProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.Rbit.RbitProperties.BusinessNameProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.BusinessName;
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
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.BusinessNameTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.BusinessNameTypes")]
        public string NameType { get; set; }
    }
}