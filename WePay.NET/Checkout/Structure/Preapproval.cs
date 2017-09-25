using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// Object that specifies unique ID of the preapproval associated with the checkout.
    /// </summary>
    public class Preapproval
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Checkout.Structure.Preapproval";

        /// <summary>
        /// Preapproval ID from Preapproval Create.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Id")]
        public long? Id { get; set; }
    }
}