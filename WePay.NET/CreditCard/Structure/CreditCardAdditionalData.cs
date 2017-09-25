using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.CreditCard.Structure
{
    /// <summary>
    /// Object that specifies additional credit card data.
    /// </summary>
    public class CreditCardAdditionalData
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Structure.CreditCardAdditionalData";

        /// <summary>
        /// Used for making a checkout call if the credit card was EMV enabled.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - TransactionToken cannot exceed 255 characters")]
        public string TransactionToken { get; set; }

        /// <summary>
        /// Structure containing receipt information for EMV transactions. This parameter should not be added to requests.
        /// It will only be present in response structures. (only present in API response)
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public EmvReceipt EmvReceipt { get; set; }

        /// <summary>
        /// Signature image URL. (only present in API response)
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - SignatureUrl cannot exceed 255 characters")]
        public string SignatureUrl { get; set; }
    }
}