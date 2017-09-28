using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePay.Checkout.Structure
{
    /// <summary>
    /// A chargeback occurs when a customer questions your charge with their bank or credit card company.
    /// When a customer disputes your charge, you are given the opportunity to respond to the dispute with evidence that shows
    /// the charge is legitimate.
    /// The chargeback object specifies whether there was a chargeback and the amount charged back.
    /// </summary>
    public class ChargebackResponse
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Structure.ChargebackResponse";

        /// <summary>
        /// If this checkout has been fully or partially charged back, this is the amount that has been charged back so far.
        /// </summary>
        public double? AmountChargedBack { get; set; }

        /// <summary>
        /// The URI that payers can visit to open a dispute for this checkout. 
        /// Do not store the returned URI on your side as it can change.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - DisputeUri cannot exceed 255 characters")]
        public string DisputeUri { get; set; }
    }
}