using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class EmailRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.EmailRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.Email;
            }
        }

        /// <summary>
        /// Email address
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Email"),
         StringLength(255, ErrorMessage = Identifier + " - Email cannot exceed 255 characters")]
        public string Email { get; set; }

        public EmailRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.Email;
        }
    }
}