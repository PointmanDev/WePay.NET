using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WePayApi.Shared
{
    public class CompositeValidationResult : ValidationResult
    {
        public List<ValidationResult> ValidationResults = new List<ValidationResult>();

        public CompositeValidationResult(string errorMessage) : base(errorMessage) { }
        public CompositeValidationResult(string errorMessage, IEnumerable<string> memberNames) : base(errorMessage, memberNames) { }
        protected CompositeValidationResult(ValidationResult validationResult) : base(validationResult) { }

        public void AddResult(ValidationResult validationResult)
        {
            ValidationResults.Add(validationResult);
        }
    }
}