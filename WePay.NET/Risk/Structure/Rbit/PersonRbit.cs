using Newtonsoft.Json;
using WePay.Risk.Structure.Rbit.RbitProperties;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit
{
    /// <summary>
    /// Information about a person associated with a user or account.
    /// It could be a person who does not have formal access to the user or account (e.g., an employee of a company who provided information).
    /// Rbits of type person are usually associated with the following related rbits: Phone and Address.
    /// </summary>
    public class PersonRbit : Rbit
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.PersonRbit";

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
                TypeContainer = Common.RbitTypes.Person;
            }
        }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// </summary>
        public new PersonProperties Properties { get; set; }
    }
}