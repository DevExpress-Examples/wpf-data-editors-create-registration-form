Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports RegistrationForm.Common
Imports RegistrationForm.DataModel
Imports System
Imports System.ComponentModel
Imports System.Windows

Namespace RegistrationForm.ViewModel
    <POCOViewModel> _
    Public Class RegistrationViewModel
        Implements IDataErrorInfo

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

            Dim error_Renamed As String = EnableValidationAndGetError()
            If error_Renamed IsNot Nothing Then
                OnValidationFailed(error_Renamed)
                Return
            End If
            EmployeesModelHelper.AddNewEmployee(FirstName, LastName, Email, Password, Birthday.Value, Gender)
            OnValidationSucceeded()
        End Sub
        Protected Sub OnPasswordChanged()
            Me.RaisePropertyChanged(Function(x) x.ConfirmPassword)
        End Sub
        Private Sub OnValidationSucceeded()
            Me.GetService(Of IMessageBoxService)().Show("Registration succeeded", "Registration Form", MessageBoxButton.OK)
        End Sub
        Private Sub OnValidationFailed(ByVal [error] As String)
            Me.GetService(Of IMessageBoxService)().Show("Registration failed. " & [error], "Registration Form", MessageBoxButton.OK)
        End Sub

        Private allowValidation As Boolean = False
        Private Function EnableValidationAndGetError() As String
            allowValidation = True

            Dim error_Renamed As String = DirectCast(Me, IDataErrorInfo).Error
            If Not String.IsNullOrEmpty(error_Renamed) Then
                Me.RaisePropertiesChanged()
                Return error_Renamed
            End If
            Return Nothing
        End Function
        Private ReadOnly Property IDataErrorInfo_Error() As String Implements IDataErrorInfo.Error
            Get
                If Not allowValidation Then
                    Return Nothing
                End If
                Dim [me] As IDataErrorInfo = DirectCast(Me, IDataErrorInfo)

                Dim error_Renamed As String = [me](BindableBase.GetPropertyName(Function() FirstName)) & [me](BindableBase.GetPropertyName(Function() LastName)) & [me](BindableBase.GetPropertyName(Function() Email)) & [me](BindableBase.GetPropertyName(Function() Password)) & [me](BindableBase.GetPropertyName(Function() ConfirmPassword)) & [me](BindableBase.GetPropertyName(Function() Birthday)) & [me](BindableBase.GetPropertyName(Function() Gender))
                If Not String.IsNullOrEmpty(error_Renamed) Then
                    Return "Please check inputted data."
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property IDataErrorInfo_Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                If Not allowValidation Then
                    Return Nothing
                End If
                Dim firstNameProp As String = BindableBase.GetPropertyName(Function() FirstName)
                Dim lastNameProp As String = BindableBase.GetPropertyName(Function() LastName)
                Dim emailProp As String = BindableBase.GetPropertyName(Function() Email)
                Dim passwordProp As String = BindableBase.GetPropertyName(Function() Password)
                Dim confirmPasswordProp As String = BindableBase.GetPropertyName(Function() ConfirmPassword)
                Dim birthdayProp As String = BindableBase.GetPropertyName(Function() Birthday)
                Dim genderProp As String = BindableBase.GetPropertyName(Function() Gender)
                If columnName = firstNameProp Then
                    Return RequiredValidationRule.GetErrorMessage(firstNameProp, FirstName)
                ElseIf columnName = lastNameProp Then
                    Return RequiredValidationRule.GetErrorMessage(lastNameProp, LastName)
                ElseIf columnName = emailProp Then
                    Return RequiredValidationRule.GetErrorMessage(emailProp, Email)
                ElseIf columnName = passwordProp Then
                    Return RequiredValidationRule.GetErrorMessage(passwordProp, Password)
                ElseIf columnName = confirmPasswordProp Then
                    If (Not String.IsNullOrEmpty(Password)) AndAlso Password <> ConfirmPassword Then
                        Return "These passwords do not match. Please try again."
                    End If
                ElseIf columnName = birthdayProp Then
                    Return RequiredValidationRule.GetErrorMessage(birthdayProp, Birthday)
                ElseIf columnName = genderProp Then
                    Return RequiredValidationRule.GetErrorMessage(genderProp, Gender, -1)
                End If
                Return Nothing
            End Get
        End Property
    End Class
End Namespace