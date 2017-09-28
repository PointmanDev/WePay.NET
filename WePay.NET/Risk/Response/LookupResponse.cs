using WePay.Risk.Structure.Rbit;
using WePay.Risk.Structure.Rbit.RbitProperties;
using WePay.Shared;

namespace WePay.Risk.Response
{
    public class LookupResponse : WePayResponse
    {
        /// <summary>
        /// The unique ID of the rbit.
        /// </summary>
        public long? RbitId { get; set; }

        /// <summary>
        /// The type of object that this rbit is associated with. 
        /// (Enumeration of these values can be found in WePay.Risk.Common.AssociatedObjectTypes)
        /// </summary>
        public string AssociatedObjectType { get; set; }

        /// <summary>
        /// The unique ID of the object that this rbit is associated with.
        /// </summary>
        public long? AssoicatedObjectId { get; set; }

        /// <summary>
        /// The type of rbit.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The properties of the rbit will depend on the type (see rbit types for a list of properties that you can set for each type).
        /// </summary>
        public RbitProperties Properties { get; set; }

        /// <summary>
        /// The Unix time when the data in this rbit was first obtained.
        /// </summary>
        public long? ReceiveTime { get; set; }

        /// <summary>
        /// Source of the information
        /// (Enumeration of these values can be found in WePay.Risk.Common.Sources)
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Free form note giving more context about the information.
        /// Used by Risk Analysts during manual review.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Array of rbits associated with this object.
        /// </summary>
        public Rbit[] RelatedRbits { get; set; }
    }
}
