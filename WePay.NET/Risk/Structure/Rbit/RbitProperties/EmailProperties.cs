using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// The email address associated with an entity.
    /// Usually passed in as a RelatedRbit of type = person
    /// </summary>
    public class EmailProperties : RbitProperties
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
        /// Email address
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }
    }
}