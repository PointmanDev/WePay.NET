using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Shared.Structure
{
    /// <summary>
    /// The theme structure contains information providing custom look-and-feel for flows and emails.
    /// </summary>
    public class Theme
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Shared.Structure.Theme";

        /// <summary>
        /// The unique theme ID (assigned by WePay).
        /// </summary>
        public long? ThemeId { get; set; }

        /// <summary>
        /// The name for the theme.
        /// </summary>
        [StringLength(64, ErrorMessage = Identifier + " - Name cannot exceed 64 characters")]
        public string Name { get; set; }

        /// <summary>
        /// The hex triplet for the primary color on important elements such as headers.
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - PrimaryColor cannot exceed 6 characters")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The hex triplet for the secondary color on elements such as info boxes, and the focus styles on text inputs.
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - SecondaryColor cannot exceed 6 characters")]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The hex triplet for the the background color for onsite and iframe pages.
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - BackgroundColor cannot exceed 6 characters")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The hex triplet for the the color for primary action buttons.
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - ButtonColor cannot exceed 6 characters")]
        public string ButtonColor { get; set; }
    }
}