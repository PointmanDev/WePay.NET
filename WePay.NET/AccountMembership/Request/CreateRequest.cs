using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.AccountMembership.Response;
using WePayApi.AccountMembership.Common;
using WePayApi.AccountMembership.Structure;
using WePayApi.Shared;

namespace WePayApi.AccountMembership.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Request.CreateRequest";

        /// <summary>
        /// The unique ID of the account for which you want to add a user.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Access token for the user to be added.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires MemberAccessToken"),
         StringLength(255, ErrorMessage = Identifier + " - MemberAccessToken cannot exceed 255 characters")]
        public string MemberAccessToken { get; set; }

        /// <summary>
        /// The role assigned to the new user.
        /// (Enumeration of these values can be found in WePayApi.AccountMembership.Common.Roles)
        /// Default: moderator
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.AccountMembership.Common.Roles")]
        public string Role { get; set; }

        /// <summary>
        /// Required if role is admin.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public AdminContext AdminContext { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (Role == Roles.Admin && AdminContext == null)
            {
                return "Invalid " + Identifier + " Admin Role requires an AdminContext.";
            }

            return null;
        }
    }
}