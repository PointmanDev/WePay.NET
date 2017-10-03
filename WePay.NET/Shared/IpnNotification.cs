namespace WePay.Shared
{
    /// <summary>
    /// Instant Payment Notifications (IPNs) allow you to receive notifications whenever the state on an object changes
    /// (or something important happens to that object).
    /// 
    /// To set up IPNs for an object, set a CallbackUri on that object.
    /// Whenever something important happens to the object that we think you should be notified of (typically a state change),
    /// we will make an HTTP POST request to your CallbackUri with the *TYPE*Id in the body of the request.
    /// </summary>
    class IpnNotification
    {
        public long? AccountId { get; set; }
        public long? CheckoutId { get; set; }
        public long? CreditCardId { get; set; }
        public long? OrderId { get; set; }
        public long? ReportId { get; set; }
        public string ReferenceId { get; set; }
        public long? UserId { get; set; }
        public long? WithdrawalId { get; set; }
    }
}