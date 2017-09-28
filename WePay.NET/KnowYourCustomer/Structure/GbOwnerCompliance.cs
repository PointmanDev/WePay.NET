using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains information about whether the owner is also a beneficial owner.
    /// </summary>
    public class GbOwnerCompliance
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Shared.KnowYourCustomer.GbOwnerCompliance";

        /// <summary>
        /// Value of true indicates the user is also a beneficial owner of the account.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires IsBeneficialOwner")]
        public bool? IsBeneficialOwner { get; set; }
    }
}