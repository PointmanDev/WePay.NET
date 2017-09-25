using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.KnowYourCustomer.Structure
{
    /// <summary>
    /// Contains standard formatted date information about an individual’s date of birth.
    /// </summary>
    public class Date
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.KnowYourCustomer.Structure.Date";

        /// <summary>
        /// The year of the user's birth.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Year")]
        public long? Year { get; set; }

        /// <summary>
        /// The month (values 1 through 12) of the user's birth.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Month")]
        public long? Month { get; set; }

        /// <summary>
        /// The day of the month (values 1 through 31) of the user's birth.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Day")]
        public long? Day { get; set; }
    }
}