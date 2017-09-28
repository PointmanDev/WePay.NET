namespace WePay.Withdrawal.Structure
{
    /// <summary>
    /// The check data structure contains information about a check issued for a withdrawal.
    /// </summary>
    public class CheckDataResponse
    {
        /// <summary>
        /// Name of the recipient.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Will contain the 2-letter US state code for US addresses.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The postcode/zip for the address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The 2-letter ISO-3166-1 country code.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Countries)
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// A short description of the reason for the withdrawal.
        /// </summary>
        public string Note { get; set; }
    }
}