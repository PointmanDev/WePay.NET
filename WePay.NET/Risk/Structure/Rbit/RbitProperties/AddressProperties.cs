using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;
using WePayApi.Shared.Structure;

namespace WePayApi.Risk.Structure.Rbit.RbitProperties
{
    public class AddressProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.Rbit.RbitProperties.AddressProperties";
        
        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.Address;
            }
        }

        /// <summary>
        /// An address associated with a user or account
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public Address Address { get; set; }

        /// <summary>
        /// The type of Address
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.AddressTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.AddressTypes")]
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
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.NormalizedAddressStatuses)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.NormalizedAddressStatuses")]
        public string NormalizedAddressStatus { get; set; }
    }
}