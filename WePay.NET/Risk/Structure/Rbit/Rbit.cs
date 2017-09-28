using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit
{
    public class Rbit : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.Rbit";

        /// <summary>
        /// The value describing the kind of risk information the rbit contains.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.RbitTypes")]
        public virtual string Type { get; set; }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// The properties of the rbit will depend on the type.
        /// </summary>
        public virtual RbitProperties.RbitProperties Properties { get; set; }

        /// <summary>
        /// The type of object that this rbit is associated with. 
        /// (Enumeration of these values can be found in WePay.Risk.Common.AssociatedObjectTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.AssociatedObjectTypes")]
        public string AssociatedObjectType { get; set; }

        /// <summary>
        /// The unique ID of the object that this rbit is associated with.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AssoicatedObjectId")]
        public long? AssoicatedObjectId { get; set; }

        /// <summary>
        /// The Unix time when the data in this rbit was first obtained.
        /// </summary>
        public long? ReceiveTime { get; set; }

        /// <summary>
        /// The type of object that this rbit is associated with. 
        /// </summary>
        public string Source { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (Properties != null && Type != null && Properties.RbitType != Type)
            {
                return "Invalid " + Identifier + ", Type == " + Type + " but Properties Type == " + Properties.RbitType + ".";
            }

            return null;
        }
    }
}