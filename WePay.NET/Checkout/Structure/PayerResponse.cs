using WePayApi.Shared.Structure;

namespace WePayApi.Checkout.Structure
{
    /// <summary>
    /// Contains information about the payer such as their name, email, and home address.
    /// This object is returned only if a payment has been made.
    /// </summary>
    public class PayerResponse
    {
        /// <summary>
        /// The name of the person paying.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The email address of the person paying.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The home address of the person paying.
        /// </summary>
        public Address HomeAddress { get; set; }
    }
}