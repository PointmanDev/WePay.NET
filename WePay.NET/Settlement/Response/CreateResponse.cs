namespace WePay.Settlement.Response
{
    public class CreateResponse : Shared.WePayResponse
    {
        /// <summary>
        /// A unique identifier for the settlement bank.
        /// </summary>
        public long? SettlementBankId { get; set; }
    }
}