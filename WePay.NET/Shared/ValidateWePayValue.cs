using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WePayApi.Shared
{
    public class ValidateWePayValue : ValidationAttribute
    {
        public bool IsRequired { get; set; }
        public string WePayValuesClassName { get; set; }
        public bool IsCommaSeparated { get; set; }
        public string RegularExpression { get; set; }

        private bool IsValidString(string value,
                                   WePayValues wePayValues)
        {
            int? index = wePayValues.GetIndexOfWePayValue(value);

            if (index != null)
            {
                return true;
            }

            if (RegularExpression != null && RegularExpression != "" && Regex.IsMatch(value, RegularExpression))
            {
                return true;
            }

            return false;
        }

        private bool IsValidStringArray(string[] values,
                                        WePayValues wePayValues)
        {
            foreach (var stringValue in values)
            {
                if (!IsValidString(stringValue, wePayValues))
                {
                    return false;
                }
            }

            return true;
        }

        protected override ValidationResult IsValid(object value,
                                                    ValidationContext validationContext)
        {
            WePayValues wePayValues = null;

            if (WePayValuesClassName != null && WePayValuesClassName != "")
            {
                Type type = Type.GetType(WePayValuesClassName);
                wePayValues = (WePayValues)Activator.CreateInstance(type);
            }

            if (IsRequired && value == null) {
                return new ValidationResult(ErrorMessage + " requires " + validationContext.DisplayName);
            }
            else if (value != null)
            {
                bool isValid = true;

                if (wePayValues != null)
                {
                    if (value is string valueString)
                    {
                        if (IsCommaSeparated)
                        {
                            var values = valueString.Split(',');

                            if (values != null && values.Length > 1)
                            {
                                isValid = IsValidStringArray(values, wePayValues);
                            }
                            else
                            {
                                isValid = IsValidString(valueString, wePayValues);
                            }
                        }
                        else
                        {
                            isValid = IsValidString(valueString, wePayValues);
                        }
                    }
                    else if (value is string[] valueArray)
                    {
                        isValid = IsValidStringArray(valueArray, wePayValues);
                    }
                }
                else
                {
                    isValid = false;
                }

                if (!isValid)
                {
                    return new ValidationResult("Invalid selection on "
                        + ErrorMessage
                        + " - "
                        + validationContext.DisplayName
                        + wePayValues != null ? " must be a value from " + wePayValues.GetType().ToString() : "");
                }
            }

            return ValidationResult.Success;
        }
    }
}