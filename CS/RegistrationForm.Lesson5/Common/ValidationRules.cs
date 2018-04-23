using DevExpress.Mvvm;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Controls;

namespace RegistrationForm.Common {
    public class RequiredValidationRule : ValidationRule {
        public static string GetErrorMessage(string fieldName, object fieldValue, object nullValue = null) {
            string errorMessage = string.Empty;
            if(nullValue != null && nullValue.Equals(fieldValue))
                errorMessage = string.Format("You cannot leave the {0} field empty.", fieldName);
            if(fieldValue == null || string.IsNullOrEmpty(fieldValue.ToString()))
                errorMessage = string.Format("You cannot leave the {0} field empty.", fieldName);
            return errorMessage;
        }
        public string FieldName { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string error = GetErrorMessage(FieldName, value);
            if(!string.IsNullOrEmpty(error))
                return new ValidationResult(false, error);
            return ValidationResult.ValidResult;
        }
    }
}
