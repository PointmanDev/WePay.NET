using WePay.Shared;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Risk.Response;
using WePay.Risk.Structure.Rbit;
using WePay.Risk.Structure.Rbit.RbitProperties;

namespace WePay.Risk.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Request.LookupRequest";

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
        /// The type of rbit.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.RbitTypes")]
        public string Type { get; set; }

        /// <summary>
        /// The properties of the rbit will depend on the type.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public RbitProperties Properties { get; set; }

        /// <summary>
        /// The Unix time when the data in this rbit was first obtained.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ReceiveTime")]
        public long? ReceiveTime { get; set; }

        /// <summary>
        /// Source of the information
        /// (Enumeration of these values can be found in WePay.Risk.Common.Sources)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.Sources")]
        public string Source { get; set; }

        /// <summary>
        /// Free form note giving more details about the information. Used by Risk Analysts during manual review.
        /// </summary>
        [StringLength(65535, ErrorMessage = Identifier + " - Note cannot exceed 65535 characters")]
        public string Note { get; set; }

        /// <summary>
        /// An array of Rbits that are related to this Rbit.
        /// For example, a person Rbit can have address (type = "Address") and social security number (type = "TaxId")
        /// Rbits associated with that person sent as related Rbits.
        /// If an Rbit is primarily associated with an associated object, then it should be passed as a top-level Rbit and
        /// not as a related Rbit.
        /// For example, a business phone number should be passed as a top-level for the account,
        /// whereas a home phone number for one employee should be passed as a related Rbit associated with the person Rbit.
        /// TIP: You do not need to specify the parameters, AssociatedObjectType and AssociatedObjectId for Rbits sent as related Rbits.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Rbit[] RelatedRbits { get; set; }

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