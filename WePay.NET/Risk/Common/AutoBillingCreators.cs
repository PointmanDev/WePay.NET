using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Creators for an AutoBilling Rbit
    /// </summary>
    public class AutoBillingCreators : WePayValues<AutoBillingCreators>
    {
        public enum Choices : int
        {
            Payer,
            Merchant
        }

        /// <summary>
        /// The payer set up and authorized auto-billing
        /// </summary>
        public const string Payer = "payer";

        /// <summary>
        /// The merchant set-up auto-billing on the payer's behalf
        /// </summary>
        public const string Merchant = "merchant";
    }
}