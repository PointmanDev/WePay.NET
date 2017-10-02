using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Shared.Structure;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class AddressRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.AddressRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.Address;
            }
        }

        /// <summary>
        /// An address associated with a user or account
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address Address { get; set; }

        /// <summary>
        /// The type of Address
        /// (Enumeration of these values can be found in WePay.Risk.Common.AddressTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.AddressTypes")]
        public string AddressType { get; set; }

        /// <summary>
        /// Normalized version of Address
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address NormalizedAddress { get; set; }

        /// <summary>
        /// String with vendor for address normalization.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - NormalizedSource cannot exceed 255 characters")]
        public string NormalizedSource { get; set; }

        /// <summary>
        /// The normalized address status
        /// (Enumeration of these values can be found in WePay.Risk.Common.NormalizedAddressStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.NormalizedAddressStatuses")]
        public string NormalizedAddressStatus { get; set; }

        public AddressRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.Address;
        }
    }
}