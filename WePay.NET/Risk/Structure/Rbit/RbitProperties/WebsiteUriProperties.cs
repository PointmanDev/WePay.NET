using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class WebsiteUriProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.WebsiteUriProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.WebsiteUri;
            }
        }

        /// <summary>
        /// Website Uri
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Uri"),
         StringLength(2083, ErrorMessage = Identifier + " - Uri cannot exceed 2083 characters")]
        public string Uri { get; set; }
    }
}