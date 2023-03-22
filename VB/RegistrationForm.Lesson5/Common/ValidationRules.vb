Imports System.Globalization
Imports System.Windows.Controls

Namespace RegistrationForm.Common

    Public Class RequiredValidationRule
        Inherits ValidationRule

        Public Shared Function GetErrorMessage(ByVal fieldName As String, ByVal fieldValue As Object, ByVal Optional nullValue As Object = Nothing) As String
            Dim errorMessage As String = String.Empty
            If nullValue IsNot Nothing AndAlso nullValue.Equals(fieldValue) Then errorMessage = String.Format("You cannot leave the {0} field empty.", fieldName)
            If fieldValue Is Nothing OrElse String.IsNullOrEmpty(fieldValue.ToString()) Then errorMessage = String.Format("You cannot leave the {0} field empty.", fieldName)
            Return errorMessage
        End Function

        Public Property FieldName As String

        Public Overrides Function Validate(ByVal value As Object, ByVal cultureInfo As CultureInfo) As ValidationResult
            Dim [error] As String = GetErrorMessage(FieldName, value)
            If Not String.IsNullOrEmpty([error]) Then Return New ValidationResult(False, [error])
            Return ValidationResult.ValidResult
        End Function
    End Class
End Namespace
