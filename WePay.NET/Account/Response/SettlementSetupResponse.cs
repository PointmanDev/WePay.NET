namespace WePayApi.Account.Response
{
    public class SettlementSetupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// Indicates the method of payment.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.SettlementPaymentMethods)
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Indicates how often the withdrawal is made.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.Frequencies)
        /// </summary>
        public string Frequency { get; set; }
    }
}