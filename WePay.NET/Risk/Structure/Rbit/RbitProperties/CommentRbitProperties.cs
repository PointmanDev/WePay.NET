using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class CommentRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.CommentRbitProperties";

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
        /// Comment text
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires CommentText"),
         StringLength(255, ErrorMessage = Identifier + " - CommentText cannot exceed 255 characters")]
        public string CommentText { get; set; }

        public CommentRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.Comment;
        }
    }
}