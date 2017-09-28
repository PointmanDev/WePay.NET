namespace WePay.Account.Structure
{
    /// <summary>
    /// Enable debit card processing for Canadian based merchants.
    /// See the Canadian user reference (https://www.wepay.com/developer/reference/canadian-users) for more details.
    /// Note: This should only be used for Canadian based merchants.
    /// It must be explicitly set to True in order for the merchant to accept payments from debit cards.
    /// </summary>
    public class CountryOptions
    {
        /// <summary>
        /// True if you want to enable debit card processing for the merchant.
        /// Default: False
        /// </summary>
        public bool? DebitOptIn { get; set; }
    }
}