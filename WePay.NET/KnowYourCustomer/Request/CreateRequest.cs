using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.KnowYourCustomer.Response;
using WePay.Shared;
using WePay.KnowYourCustomer.Structure;

namespace WePay.KnowYourCustomer.Request
{
    public class CreateRequest : WePayRequest<CreateResponse>, IRequiresAdditonalValidation
    {
        [JsonIgnore]
        private const string Identifier = "WePay.KnowYourCustomer.Request.CreateRequest";

        /// <summary>
        /// A unique ID for the application.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ClientId")]
        public long? ClientId { get; set; }

        /// <summary>
        /// The unique ID of the account for which KYC information is being submitted.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Required if neither Business or Organization are not specified.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public Individual Individual { get; set; }

        /// <summary>
        /// Required if neither Individual or Organization are not specified.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public BusinessOrOrganization Business { get; set; }

        /// <summary>
        /// Required if neither Individual or Business are not specified.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public BusinessOrOrganization Organization { get; set; }

        public string GetAdditonalValidationErrorMessage()
        {
            int numberOfInitialized = 0;

            if (Individual != null)
            {
                ++numberOfInitialized;
            }

            if (Business != null)
            {
                ++numberOfInitialized;
            }

            if (Organization != null)
            {
                ++numberOfInitialized;
            }

            return numberOfInitialized == 0 || numberOfInitialized > 1 ? "Invalid " + Identifier + ", requires exactly one of Individual, Business or Organization to be non-null" : null;
        }
    }
}