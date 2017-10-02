using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class PhoneRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.PhoneRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.Phone;
            }
        }

        /// <summary>
        /// Phone number, ideally including country code prefix (+1 for US)
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Phone"),
         StringLength(32, ErrorMessage = Identifier + " - Phone cannot exceed 32 characters")]
        public string Phone { get; set; }

        /// <summary>
        /// The type of phone number.
        /// (Enumeration of these values can be found in WePay.Risk.Common.PhoneTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.PhoneTypes")]
        public string PhoneType { get; set; }

        public PhoneRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.Phone;
        }
    }
}