using WePayApi.Shared;

namespace WePayApi.Account.Common
{
    /// <summary>
    /// All Incoming and Outgoing Payments statuses
    /// </summary>
    public class PaymentsStatuses : WePayValues<PaymentsStatuses>
    {
        public enum Choices : int
        {
            Ok,
            Paused
        }

        public const string Ok = "ok";
        public const string Paused = "paused";
    }
}