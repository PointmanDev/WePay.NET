using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.Shared.Structure;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class TransactionDetailsProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.TransactionDetailsProperties";

        /// <summary>
        /// Not an API field, only use for validating requests, mainly for testing purposes
        /// </summary>
        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitTypeContainer;
            }
            set
            {
                RbitTypeContainer = Common.RbitTypes.TransactionDetails;
            }
        }

        /// <summary>
        /// The buyer agreement or transactions page URL on the application's website or service (e.g. receipt page).
        /// It can be HTML, PDF, image, or any other type of file.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - ReceiptUri cannot exceed 2083 characters")]
        public string ReceiptUri { get; set; }

        /// <summary>
        /// Array of ReceiptLineItems providing all the line item details of the transaction (including tax and shipping line items).
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public ReceiptLineItem[] ItemizedReceipt { get; set; }

        /// <summary>
        /// URL of the terms of service for the transaction.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - TermsUri cannot exceed 2083 characters")]
        public string TermsUri { get; set; }

        /// <summary>
        /// The shipping address for this transaction (if transaction is shipped).
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Array of ShippingInfos that describe the shipment status.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public ShippingInfo[] ShippingInfo { get; set; }

        /// <summary>
        /// Optional address of where the service is consumed.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Address ServiceAddress { get; set; }

        /// <summary>
        /// Terms associated with the invoice or transaction.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - TermsText cannot exceed 2083 characters")]
        public string TermsText { get; set; }

        /// <summary>
        /// Purchase order number.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - PoNumber cannot exceed 2083 characters")]
        public string PoNumber { get; set; }

        /// <summary>
        /// Discount (if any) on the order.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - Discount cannot exceed 2083 characters")]
        public string Discount { get; set; }

        /// <summary>
        /// Optional note on the invoice or address.
        /// </summary>
        [StringLength(10000, ErrorMessage = Identifier + " - Note cannot exceed 10000 characters")]
        public string Note { get; set; }
    }
}