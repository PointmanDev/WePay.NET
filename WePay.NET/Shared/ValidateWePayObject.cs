using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Shared
{
    public class ValidateWePayObjectAttribute : ValidationAttribute
    {
        public bool IsRequired { get; set; }

        private ValidationResult GetAdditonalValidationErrorMessage(object value)
        {
            if (value is IRequiresAdditonalValidation iRequiresAdditonalValidation)
            {
                string additionalValidationErrorMessage = iRequiresAdditonalValidation.GetAdditonalValidationErrorMessage();

                if (additionalValidationErrorMessage != null)
                {
                    return new ValidationResult(additionalValidationErrorMessage);
                }
            }

            return null;
        }

        private string ValidateNonEnumerableObject(object value,
                                                   ValidationContext validationContext,
                                                   List<ValidationResult> validationResults)
        {
            string errorMessage = "";
            var validationContextInner = new ValidationContext(value, null, null);
            Validator.TryValidateObject(value, validationContextInner, validationResults, true);
            var additionalValidationResult = GetAdditonalValidationErrorMessage(value);

            if (additionalValidationResult != null)
            {
                validationResults.Add(additionalValidationResult);
            }

            if (validationResults.Count > 0)
            {
                foreach (var validationResult in validationResults)
                {
                    errorMessage += ErrorMessage + " - " + validationContext.DisplayName + " - " + validationResult.ErrorMessage + "\n";
                }
            }

            return null;
        }

        protected override ValidationResult IsValid(object value,
                                                    ValidationContext validationContext)
        {
            if (IsRequired && value == null)
            {
                return new ValidationResult(ErrorMessage + " requires " +  validationContext.DisplayName);
            }
            else if (value != null)
            {
                if (value is IEnumerable iEnumerable)
                {
                    string errorMessage = "";
                    string childErrorMessage;
                    var validationResults = new List<List<ValidationResult>>();
                    int childIndex = 0;

                    foreach (var child in iEnumerable)
                    {
                        childErrorMessage = ValidateNonEnumerableObject(value, validationContext, validationResults[childIndex]);

                        if (childErrorMessage != null)
                        {
                            errorMessage += "Validation Error in Collection: " + ErrorMessage + " at index " + childIndex.ToString() + "\n";
                            errorMessage += childErrorMessage;
                        }

                        ++childIndex;
                    }

                    if (errorMessage != "")
                    {
                        var compositeValidationResult = new CompositeValidationResult(errorMessage);

                        foreach (var validationResult in validationResults)
                        {
                            validationResult.ForEach(compositeValidationResult.AddResult);
                        }

                        return compositeValidationResult;
                    }
                }
                else
                {
                    var validationResults = new List<ValidationResult>();
                    string errorMessage = ValidateNonEnumerableObject(value, validationContext, validationResults);

                    if (errorMessage != null)
                    {
                        var compositeValidationResult = new CompositeValidationResult(errorMessage);
                        validationResults.ForEach(compositeValidationResult.AddResult);
                        return compositeValidationResult;
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}