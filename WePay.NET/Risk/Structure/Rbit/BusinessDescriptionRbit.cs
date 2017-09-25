using Newtonsoft.Json;
using WePayApi.Risk.Structure.Rbit.RbitProperties;
using WePayApi.Shared;

namespace WePayApi.Risk.Structure.Rbit
{
    public class BusinessDescriptionRbit : Rbit
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.Rbit.BusinessDescriptionRbit";

        /// <summary>
        /// The value describing the kind of risk information the rbit contains.
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.RbitTypes)
        /// PROTIP: You don't need to set this, I already did it for you
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.RbitTypes")]
        public override string Type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = Common.RbitTypes.BusinessDescription;
            }
        }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// </summary>
        public new BusinessDescriptionProperties Properties { get; set; }
    }
}