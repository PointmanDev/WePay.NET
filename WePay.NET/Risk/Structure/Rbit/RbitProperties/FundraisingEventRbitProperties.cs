using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class FundraisingEventRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.FundraisingEventRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.FundraisingEvent;
            }
        }

        /// <summary>
        /// Name of the fundraising event.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Name"),
         StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The Unix time of when the event starts.
        /// </summary>
        public long? EventTime { get; set; }

        /// <summary>
        /// The Unix time of deadline for when donations will no longer be accepted.
        /// </summary>
        public long? GivingDeadline { get; set; }

        /// <summary>
        /// The fundraising goal established by the event organizers
        /// </summary>
        public double? FundraisingGoal { get; set; }

        /// <summary>
        /// The currency used.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// URI that points to the fundraising event page
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - Uri cannot exceed 2083 characters")]
        public string Uri { get; set; }

        public FundraisingEventRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.FundraisingEvent;
        }
    }
}