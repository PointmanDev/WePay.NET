namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// This structure contains information about a non profit entity
    /// </summary>
    public class NonProfitInformation
    {
        /// <summary>
        /// Legal name of the non-profit entity.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Employer Identification Number of the non-profit entity.
        /// </summary>
        public string Ein { get; set; }
    }
}