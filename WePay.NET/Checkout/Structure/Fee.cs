using Newtonsoft.Json;
using WePay.Shared;

namespace WePay.Checkout.Structure
{
    /// <summary>
    /// Specifies the App Fee and Fee Payer parameters for a checkout.
    /// </summary>
    public class Fee
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Structure.Fee";

        /// <summary>
        /// The dollar amount that the application will receive in fees.
        /// App fees go into the API applications W
        /// Default: 0
        /// </summary>
        public double? AppFee { get; set; }

        /// <summary>
        /// Who will pay the fees (WePay's fees and any app fees).
        /// (Enumeration of these values can be found in WePay.Checkout.Common.FeePayers)
        /// For EMV transactions the value must be either payee or payee_from_app.
        /// Default: Payer
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Checkout.Common.FeePayers")]
        public string FeePayer { get; set; }
    }
}