using Newtonsoft.Json;
using WePay.Risk.Structure.Rbit.RbitProperties;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit
{
    /// <summary>
    /// This type describes one type of service or product the user has signed up for on the partner site.
    /// This should be passed as a related rbit of the ExternalAccount rbit that contains partner site information.
    /// If the user is signed up for multiple services, you can pass multiple related rbits.
    /// </summary>
    public class PartnerServiceRbit : Rbit
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.PartnerServiceRbit";

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
                TypeContainer = Common.RbitTypes.PartnerService;
            }
        }

        /// <summary>
        /// A parameter set to the key value pair of properties for this type.
        /// </summary>
        public new PartnerServiceProperties Properties { get; set; }
    }
}