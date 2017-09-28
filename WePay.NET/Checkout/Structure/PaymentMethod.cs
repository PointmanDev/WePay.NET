using Newtonsoft.Json;
using WePay.Checkout.Common;
using WePay.Shared;

namespace WePay.Checkout.Structure
{
    /// <summary>
    /// Send the payment method object to pay for a checkout using previously acquired payment information,
    /// such as a credit card (for tokenization) or preapproval (Depreated).
    /// Based on the type, only specify payment_bank, credit_card, or preapproval parameters.
    /// For example, if the payment method has type = credit_card, specify the credit_card parameter and do not specify the preapproval.
    /// </summary>
    public class PaymentMethod : IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Checkout.Structure.PaymentMethod";

        /// <summary>
        /// Payment Method type.
        /// (Enumeration of these values can be found in WePay.Checkout.Common.PaymentTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, IsRequired = true, WePayValuesClassName = "WePay.Checkout.Common.PaymentTypes")]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the payment bank.
        /// Required if Type is PaymentBank.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public PaymentBank.Structure.PaymentBank PaymentBank { get; set; }

        /// <summary>
        /// Specifies the credit card.
        /// Required if Type is CreditCard.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public CreditCard.Structure.CreditCard CreditCard { get; set; }

        /// <summary>
        /// [DEPRECATED] Specifies the preapproval.
        /// Required if Type is Preapproval.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Preapproval Preapproval { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            string errorPrefix = "Invalid " + Identifier + ", ";
            bool isValid = false;
            
            if (Type != null)
            {
                switch (Type)
                {
                    case PaymentTypes.CreditCard:
                        {
                            isValid = true;

                            if (CreditCard == null || PaymentBank != null || Preapproval != null)
                            {
                                return errorPrefix + " requires only CreditCard object to be non-null";
                            }

                            break;
                        }
                    case PaymentTypes.PaymentBank:
                        {
                            isValid = true;

                            if (PaymentBank == null || Preapproval != null || CreditCard != null)
                            {
                                return errorPrefix + " requires only PaymentBank object to be non-null";
                            }

                            break;
                        }
                    case PaymentTypes.Preapproval:
                        {
                            isValid = true;

                            if (Preapproval == null || CreditCard != null || PaymentBank != null)
                            {
                                return errorPrefix + " requires only Preapproval object to be non-null";
                            }

                            break;
                        }
                }

                return isValid ? null : "could not identify an appropriate Type (PaymentType)";
            }

            return errorPrefix + "requires Type to determine the appropriate PaymentType object.";
        }
    }
}