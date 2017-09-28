using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Shared.Structure;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    /// <summary>
    /// Information about a person associated with a user or account.
    /// It could be a person who does not have formal access to the user or account (e.g., an employee of a company who provided information).
    /// Rbits of type person are usually associated with the following related rbits: Phone and Address.
    /// </summary>
    public class PersonProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.PersonProperties";

        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitType;
            }
            set
            {
                RbitType = Common.RbitTypes.Person;
            }
        }

        /// <summary>
        /// The full name of the person
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Name"),
         StringLength(255, ErrorMessage = Identifier + " - Name cannot exceed 255 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The birthdate of the person. Must be in YYYY-MM-DD format. i.e 1989-08-10
        /// </summary>
        [StringLength(12, ErrorMessage = Identifier + " - Birthdate must be exactly 12 characters", MinimumLength = 12),
         RegularExpression(@"", ErrorMessage = Identifier + " - Birthdate must have the form YYYY-MM-DD")]
        public string Birthdate { get; set; }

        /// <summary>
        /// The role the person currently satisfies
        /// (Enumeration of these values can be found in WePay.Risk.Common.PersonRoles)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.PersonRoles")]
        public string Role { get; set; }
    }
}