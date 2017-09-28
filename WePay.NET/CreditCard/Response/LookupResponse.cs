namespace WePay.CreditCard.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of a credit card.
        /// </summary>
        public long? CreditCardId { get; set; }

        /// <summary>
        /// The string that identifies a credit card, such as MasterCard xxxxxx4769
        /// </summary>
        public string CreditCardName { get; set; }

        /// <summary>
        /// The state that the credit card is in.
        /// (Enumeration of these values can be found in WePay.CreditCard.Common.CreditCardStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The name on the card (e.g., Bob Smith).
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The email address of the user who owns the card.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) when the credit card was created.
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// The input source of the credit card.
        /// (Enumeration of these values can be found in WePay.CreditCard.Common.InputSources)
        /// </summary>
        public string InputSource { get; set; }

        /// <summary>
        /// The virtual terminal mode of the credit card.
        /// (Enumeration of these values can be found in WePay.CreditCard.Common.VirtualTerminalModes)
        /// </summary>
        public string VirtualTerminalMode { get; set; }

        /// <summary>
        /// The unique ID for the credit card.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// The expiration month on the credit card.
        /// Possible values: integers between 1 and 12.
        /// </summary>
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// The expiration year on the credit card.
        /// </summary>
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// Bank identification number. The initial six digits of a credit card number. null is returned if BIN is not available. 
        /// When the InputSource is ApplePay or AndroidPay, BIN is a virtual value and should not be considered as the actual BIN number.
        /// </summary>
        public string Bin { get; set; }

        /// <summary>
        /// The last four digits of the credit card number.
        /// </summary>
        public string LastFour { get; set; }

        /// <summary>
        /// The backing instrument for the credit card such as Visa 2149.
        /// Value exists for digital wallet payments, null otherwise.
        /// </summary>
        public string BackingInstrumentName { get; set; }
    }
}