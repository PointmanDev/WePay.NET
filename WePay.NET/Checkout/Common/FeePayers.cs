using WePayApi.Shared;

namespace WePayApi.Checkout.Common
{
    public class FeePayers : WePayValues<FeePayers>
    {
        public enum Choices : int
        {
            Payer,
            Payee,
            PayerFromApp,
            PayeeFromApp
        }

        /// <summary>
        /// Charge fees to the person paying (payer will pay amount + fees, and payee will receive amount).
        /// </summary>
        public const string Payer = "payer";

        /// <summary>
        /// Charge fees to the person receiving money (payer will pay amount, and payee will receive amount - fees).
        /// </summary>
        public const string Payee = "payee";

        /// <summary>
        /// Payer will be charged app fee (if there is one) and API application will be charged WePay fee.
        /// Note that if the application's account goes negative, WePay will recover funds from bank account.
        /// </summary>
        public const string PayerFromApp = "payer_from_app";

        /// <summary>
        /// Payee will be charged the app fee (if there is one) and the API application will be charged the WePay fee.
        /// Note that if the application's account goes negative, WePay will recover funds from bank account.
        /// </summary>
        public const string PayeeFromApp = "payee_from_app";
    }
}