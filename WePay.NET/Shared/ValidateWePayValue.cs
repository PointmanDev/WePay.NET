using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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
                                   List<string> wePayValues)
        {
            int index = wePayValues.IndexOf(value);

            if (index > -1)
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
                                        List<string> wePayValues)
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
            List<string> wePayValues = null;

            if (WePayValuesClassName != null && WePayValuesClassName != "")
            {
                Type type = Type.GetType(WePayValuesClassName);
                PropertyInfo propertyInfo = type.GetProperty("Values");

                if (propertyInfo != null)
                {
                    wePayValues = (List<string>)propertyInfo.GetValue(type, null);
                }
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