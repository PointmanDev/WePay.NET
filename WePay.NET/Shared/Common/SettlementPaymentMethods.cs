namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible settlement payment methods currently supported by WePay
    /// </summary>
    public class SettlementPaymentMethods : WePayValues<SettlementPaymentMethods>
    {
        public enum Indices : int
        {
            Ach,
            Check
        }

        public const string Ach = "ach";
        public const string Check = "check";
    }
}