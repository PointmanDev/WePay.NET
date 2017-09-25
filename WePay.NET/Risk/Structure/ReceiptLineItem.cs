using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Shared;

namespace WePayApi.Risk.Structure
{
    /// <summary>
    /// Contains details about a specific line item on a receipt.
    /// </summary>
    public class ReceiptLineItem : IRequiresAdditonalValidation
    {
        private void SetAmount()
        {
            if (ItemPrice != null && Quantity != null)
            {
                Amount = Quantity * ItemPrice;
            }
            else
            {
                Amount = null;
            }
        }

        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Structure.ReceiptLineItem";

        /// <summary>
        /// Line item description.
        /// Could be a normal line item, a discount line item, tax, or shipping.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Identifier + " - Requires Description"),
         StringLength(1023, ErrorMessage = Identifier + " - Description cannot exceed 1023 characters")]
        public string Description { get; set; }

        /// <summary>
        /// Item price per unit.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ItemPrice")]
        public double? ItemPrice
        {
            get
            {
                return ItemPrice;
            }
            set
            {
                ItemPrice = value;
                SetAmount();
            }
        }
        
        /// <summary>
        /// Quantity of the line items.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Quantity")]
        public double? Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
                SetAmount();
            }
        }

        /// <summary>
        /// The currency used.
        /// (Enumeration of these values can be found in WePayApi.Shared.Common.Currencies)
        /// Default: US
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Shared.Common.Currencies")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount = (ItemPrice x Quantity)
        /// PROTIP: You don't need to set this, I made a setter that does it for you as long as you set the Quantity and ItemPrice.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Name of project this item is related to.
        /// If a separate "project" rbit is provided, this should match the project name in that rbit.
        /// </summary>
        [StringLength(1023, ErrorMessage = Identifier + " - ProjectName cannot exceed 1023 characters")]
        public string ProjectName { get; set; }

        /// <summary>
        /// The service billing method used.
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.ServiceBillingMethods)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.ServiceBillingMethods")]
        public string ServiceBillingMethod { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            if (ItemPrice != null && Quantity != null && Amount != null && Amount != ItemPrice * Quantity)
            {
                return "Invalid " + Identifier + ", Amount must equal ItemPrice * Quantity";
            }

            return null;
        }
    }
}