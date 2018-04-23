Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports RegistrationForm.DataModel
Imports System

Namespace RegistrationForm.ViewModel
    <POCOViewModel> _
    Public Class RegistrationViewModel
        Public Shared Function Create() As RegistrationViewModel
            Return ViewModelSource.Create(Function() New RegistrationViewModel())
        End Function
        Protected Sub New()
            MinBirthday = New Date(Date.Now.Year - 100, 12, 31)
            MaxBirthday = New Date(Date.Now.Year - 1, 12, 31)
            If Me.IsInDesignMode() Then
                InitializeInDesignMode()
            Else
                InitializeInRuntime()
            End If
        End Sub
        Private Sub InitializeInDesignMode()
            FirstName = "John"
            LastName = "Smith"
            Email = "John.Smith@JohnSmithMail.com"
            Password = "Password"
            ConfirmPassword = "Password"
            Birthday = New Date(1980, 1, 1)
            Gender = 1
        End Sub
        Private Sub InitializeInRuntime()
            Birthday = Nothing
            Gender = -1
        End Sub

        Public Overridable Property FirstName() As String
        Public Overridable Property LastName() As String
        Public Overridable Property Email() As String
        Public Overridable Property Password() As String
        Public Overridable Property ConfirmPassword() As String
        Public Overridable Property Birthday() As Date?
        Public Overridable Property MinBirthday() As Date
        Public Overridable Property MaxBirthday() As Date
        Public Overridable Property Gender() As Integer

        Public Sub AddEmployee()
            EmployeesModelHelper.AddNewEmployee(FirstName, LastName, Email, Password, Birthday.Value, Gender)
        End Sub
    End Class
End Namespace