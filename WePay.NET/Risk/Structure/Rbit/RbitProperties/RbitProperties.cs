using Newtonsoft.Json;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// Base class for RbitProperties
    /// </summary>
    public class RbitProperties
    {
        /// <summary>
        /// Holds the value for type so it can't be overridden
        /// </summary>
        [JsonIgnore]
        protected string RbitTypeContainer { get; set; }

        /// <summary>
        /// The value describing the kind of risk information the rbit contains.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// </summary>
        [JsonIgnore]
        public virtual string RbitType
        {
            get
            {
                return RbitTypeContainer;
            }
            set
            {
                RbitTypeContainer = value;
            }
        }
    }
}