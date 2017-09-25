using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.AccountMembership.Response;
using WePayApi.AccountMembership.Common;
using WePayApi.AccountMembership.Structure;
using WePayApi.Shared;

namespace WePayApi.AccountMembership.Request
{
    public class ModifyRequest : WePayRequest<LookupResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Account.Request.ModifyRequest";

        /// <summary>
        /// The unique ID of the account for which you want to modify a user.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// The unique ID of the user to be modified.
        /// </summary>
        [Required(ErrorMessage = Identifier+ " - Requires UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// New role.
        /// (Enumeration of these values can be found in WePayApi.AccountMembership.Common.Roles)
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