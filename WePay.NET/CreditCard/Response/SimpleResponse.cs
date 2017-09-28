namespace WePay.CreditCard.Response
{
    public class SimpleResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the credit card.
        /// </summary>
        public long? CreditCardId { get; set; }
    }
}