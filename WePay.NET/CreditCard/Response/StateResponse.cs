namespace WePay.CreditCard.Response
{
    public class StateResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the credit card.
        /// </summary>
        public long? CreditCardId { get; set; }

        /// <summary>
        /// The unique ID of the credit card.
        /// (Enumeration of these values can be found in WePay.CreditCard.Common.CreditCardStates)
        /// </summary>
        public string State { get; set; }
    }
}