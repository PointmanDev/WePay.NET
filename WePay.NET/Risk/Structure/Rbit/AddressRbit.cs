using Newtonsoft.Json;
using WePay.Risk.Structure.Rbit.RbitProperties;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit
{
    /// <summary>
    /// A mailing address associated with a user or account.
    /// Rbits of type address should be sent either as a related rbit of type = person or as a top level rbit
    /// for an account
    /// </summary>
    public class AddressRbit : Rbit
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.AddressRbit";

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
                TypeContainer = Common.RbitTypes.Address;
            }
        }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// </summary>
        public new AddressProperties Properties { get; set; }
    }
}