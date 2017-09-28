using System.ComponentModel.DataAnnotations;

namespace WePay.Checkout.Structure
{
    /// <summary>
    /// Contains information about the App Fee, processing fee paid to WePay, and Fee Payer.
    /// </summary>
    public class FeeResponse
    {
        /// <summary>
        /// The dollar amount that the application will receive in fees.
        /// App fees go into the API applications WePay account.
        /// Limited to 20% of the checkout amount.
        /// </summary>
        public double? AppFee { get; set; }

        /// <summary>
        /// The dollar amount paid to WePay as a fee.
        /// </summary>
        public double? ProcessingFee { get; set; }

        /// <summary>
        /// Who will pay the fees(WePay's fees and any app fees).
        /// (Enumeration of these values can be found in WePay.Checkout.Common.FeePayers)
        /// </summary>
        public string FeePayer { get; set; }
    }
}