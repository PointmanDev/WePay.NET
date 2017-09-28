using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// Information about an event that is the context for a donation transaction or donation account.
    /// It can therefore be passed as an rbit associated with a checkout or an account.
    /// </summary>
    public class FundraisingEventProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.FundraisingEventProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.FundraisingEvent;
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
    }
}