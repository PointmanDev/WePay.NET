using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class WebsiteUriRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.WebsiteUriRbitProperties";

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
                RbitTypeContainer = Common.RbitTypes.WebsiteUri;
            }
        }

        /// <summary>
        /// Website Uri
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Uri"),
         StringLength(2083, ErrorMessage = Identifier + " - Uri cannot exceed 2083 characters")]
        public string Uri { get; set; }

        public WebsiteUriRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.WebsiteUri;
        }
    }
}