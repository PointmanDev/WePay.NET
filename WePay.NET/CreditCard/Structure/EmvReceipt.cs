using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.CreditCard.Structure
{
    /// <summary>
    /// Structure containing receipt information for EMV transactions.
    /// </summary>
    public class EmvReceipt
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.CreditCard.Structure.EmvReceipt";

        /// <summary>
        /// The label of the EMV Application.
        /// </summary>
        [StringLength(64, ErrorMessage = Identifier + " - ApplicationLabel cannot exceed 64 characters")]
        public string ApplicationLabel { get; set; }

        /// <summary>
        /// The application identifier (AID).
        /// </summary>
        [StringLength(64, ErrorMessage = Identifier + " - ApplicationIdentifier cannot exceed 64 characters")]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// The terminal's identification number.
        /// </summary>
        [StringLength(64, ErrorMessage = Identifier + " - TerminalIdentification cannot exceed 64 characters")]
        public string TerminalIdentification { get; set; }

        /// <summary>
        /// The type of financial transaction.
        /// </summary>
        [StringLength(2, ErrorMessage = Identifier + " - TransactionType cannot exceed 2 characters")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Cryptogram returned by the card when it approves a transaction.
        /// </summary>
        [StringLength(16, ErrorMessage = Identifier + " - TransactionCertificate cannot exceed 16 characters")]
        public string TransactionCertificate { get; set; }

        /// <summary>
        /// The transaction authorization code.
        /// </summary>
        [StringLength(6, ErrorMessage = Identifier + " - AuthorizationCode cannot exceed 6 characters")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// The merchant ID (mid) used for the transaction.
        /// </summary>
        [StringLength(64, ErrorMessage = Identifier + " - MerchantId cannot exceed 64 characters")]
        public string MerchantId { get; set; }

        /// <summary>
        /// The merchant's name.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - MerchantName cannot exceed 255 characters")]
        public string MerchantName { get; set; }
    }
}