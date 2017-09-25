using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Shared
{
    public abstract class WePayRequest<T> where T : WePayResponse
    {
        private static string ValidationResultsToString(List<ValidationResult> validationResults)
        {
            string errorMessage = null;
            string subErrorMessage;

            if (validationResults.Count > 0)
            {
                errorMessage = "";

                foreach (var validationResult in validationResults)
                {
                    errorMessage += validationResult.ErrorMessage;

                    if (validationResult is CompositeValidationResult compositeValidationResult)
                    {
                        subErrorMessage = ValidationResultsToString(compositeValidationResult.ValidationResults);
                        errorMessage += subErrorMessage ?? "";
                    }
                    else
                    {
                        errorMessage += "\n";
                    }
                }
            }

            return errorMessage;
        }

        public string ValidateRequest()
        {
            var validationContext = new ValidationContext(this, null, null);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(this, validationContext, validationResults, true);

            return ValidationResultsToString(validationResults);
        }
    }
}