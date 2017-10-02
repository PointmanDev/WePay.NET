using Newtonsoft.Json;
using WePay.Risk.Structure.Rbit.RbitProperties;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit
{
    /// <summary>
    /// A code from one of several sources that indicates the industry associated with the business.
    /// </summary>
    public class IndustryCodeRbit : Rbit
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.IndustryCodeRbit";

        /// <summary>
        /// The value describing the kind of risk information the rbit contains.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// PROTIP: You don't need to set this, I already did it for you
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.RbitTypes")]
        public override string Type
        {
            get
            {
                return TypeContainer;
            }
            set
            {
                TypeContainer = Common.RbitTypes.IndustryCode;
            }
        }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// </summary>
        public new IndustryCodeProperties Properties { get; set; }
    }
}
