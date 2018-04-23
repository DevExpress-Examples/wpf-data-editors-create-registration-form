Imports DevExpress.Mvvm
Imports System
Imports System.Globalization
Imports System.Linq.Expressions
Imports System.Windows.Controls

Namespace RegistrationForm.Common
    Public Class RequiredValidationRule
        Inherits ValidationRule

        Public Shared Function GetErrorMessage(ByVal fieldName As String, ByVal fieldValue As Object, Optional ByVal nullValue As Object = Nothing) As String
            Dim errorMessage As String = String.Empty
            If nullValue IsNot Nothing AndAlso nullValue.Equals(fieldValue) Then
                errorMessage = String.Format("You cannot leave the {0} field empty.", fieldName)
            End If
            If fieldValue Is Nothing OrElse String.IsNullOrEmpty(fieldValue.ToString()) Then
                errorMessage = String.Format("You cannot leave the {0} field empty.", fieldName)
            End If
            Return errorMessage
        End Function
        Public Property FieldName() As String
        Public Overrides Function Validate(ByVal value As Object, ByVal cultureInfo As CultureInfo) As ValidationResult
            Dim [error] As String = GetErrorMessage(FieldName, value)
            If Not String.IsNullOrEmpty([error]) Then
                Return New ValidationResult(False, [error])
            End If
            Return ValidationResult.ValidResult
        End Function
    End Class
End Namespace
