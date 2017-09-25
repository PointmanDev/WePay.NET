namespace WePayApi.CreditCard.Response
{
    public class StateResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the credit card.
        /// </summary>
        public long? CreditCardId { get; set; }

        /// <summary>
        /// The unique ID of the credit card.
        /// (Enumeration of these values can be found in WePayApi.CreditCard.Common.CreditCardStates)
        /// </summary>
        public string State { get; set; }
    }
}