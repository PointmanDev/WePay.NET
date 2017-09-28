namespace WePay.Account.Structure
{
    public class FeeSchedule
    {
        /// <summary>
        /// The 1-based number assigned to the custom fee schedule, if applied.
        /// If no custom fee schedule is applied, the value returned is 0.
        /// </summary>
        public long? Slot { get; set; }

        /// <summary>
        /// The textual description of the fee schedule.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The currency identifier that applies to the fee schedule.
        /// (Enumeration of these values can be found in WePay.Shared.Common.Currencies)
        /// </summary>
        public string Currency { get; set; }
    }
}