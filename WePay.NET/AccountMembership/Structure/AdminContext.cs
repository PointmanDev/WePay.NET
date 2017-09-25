using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.AccountMembership.Common;
using WePayApi.Shared;

namespace WePayApi.AccountMembership.Structure
{
    /// <summary>
    /// Describes the context of an account administrator.
    /// </summary>
    public class AdminContext : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.AccountMembership.Structure.AdminContext";

        /// <summary>
        /// The reason the person is an administrator (role).
        /// (Enumeration of these values can be found in WePayApi.AccountMembership.Common.Reasons)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.AccountMembership.Common.Reasons")]
        public string Reason { get; set; }

        /// <summary>
        /// An explanation of why the person is an admistrator for this account if not the beneficiary.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Explanation cannot exceed 255 characters")]
        public string Explanation { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (Reason != Reasons.Beneficiary && (Explanation == null || Explanation == ""))
            {
                return "Invalid " + Identifier + ", non-Beneficiary Reason must include an Explanation.";
            }

            return null;
        }
    }
}