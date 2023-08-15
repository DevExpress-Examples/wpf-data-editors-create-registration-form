Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports RegistrationForm.DataModel
Imports System
Imports System.ComponentModel
Imports System.Windows

Namespace RegistrationForm.ViewModel

    <POCOViewModel>
    Public Class RegistrationViewModel
        Implements IDataErrorInfo

        Public Shared Function Create() As RegistrationViewModel
            Return ViewModelSource.Create(Function() New RegistrationViewModel())
        End Function

        Protected Sub New()
            MinBirthday = New DateTime(Date.Now.Year - 100, 12, 31)
            MaxBirthday = New DateTime(Date.Now.Year - 1, 12, 31)
            If IsInDesignMode() Then
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
            Birthday = New DateTime(1980, 1, 1)
            Gender = 1
        End Sub

        Private Sub InitializeInRuntime()
            Birthday = Nothing
            Gender = -1
        End Sub

        Public Overridable Property FirstName As String

        Public Overridable Property LastName As String

        Public Overridable Property Email As String

        Public Overridable Property Password As String

        Public Overridable Property ConfirmPassword As String

        Public Overridable Property Birthday As Date?

        Public Overridable Property MinBirthday As Date

        Public Overridable Property MaxBirthday As Date

        Public Overridable Property Gender As Integer

        Public Sub AddEmployee()
            Dim [error] As String = EnableValidationAndGetError()
            If Not Equals([error], Nothing) Then
                OnValidationFailed([error])
                Return
            End If

            AddNewEmployee(FirstName, LastName, Email, Password, Birthday.Value, Gender)
            OnValidationSucceeded()
        End Sub

        Protected Sub OnPasswordChanged()
            RaisePropertyChanged(Function(x) x.ConfirmPassword)
        End Sub

        Private Sub OnValidationSucceeded()
            GetService(Of IMessageBoxService).Show("Registration succeeded", "Registration Form", MessageBoxButton.OK)
        End Sub

        Private Sub OnValidationFailed(ByVal [error] As String)
            GetService(Of IMessageBoxService).Show("Registration failed. " & [error], "Registration Form", MessageBoxButton.OK)
        End Sub

        Private allowValidation As Boolean = False

        Private Function EnableValidationAndGetError() As String
            allowValidation = True
            Dim [error] As String = CType(Me, IDataErrorInfo).Error
            If Not String.IsNullOrEmpty([error]) Then
                RaisePropertiesChanged()
                Return [error]
            End If

            Return Nothing
        End Function

        Private ReadOnly Property [Error] As String Implements IDataErrorInfo.[Error]
            Get
                If Not allowValidation Then Return Nothing
                Dim [me] As IDataErrorInfo = CType(Me, IDataErrorInfo)
                Dim lError As String = [me](BindableBase.GetPropertyName(Function() FirstName)) & [me](BindableBase.GetPropertyName(Function() LastName)) & [me](BindableBase.GetPropertyName(Function() Email)) & [me](BindableBase.GetPropertyName(Function() Password)) & [me](BindableBase.GetPropertyName(Function() ConfirmPassword)) & [me](BindableBase.GetPropertyName(Function() Birthday)) & [me](BindableBase.GetPropertyName(Function() Gender))
                If Not String.IsNullOrEmpty(lError) Then Return "Please check inputted data."
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                If Not allowValidation Then Return Nothing
                Dim firstNameProp As String = BindableBase.GetPropertyName(Function() FirstName)
                Dim lastNameProp As String = BindableBase.GetPropertyName(Function() LastName)
                Dim emailProp As String = BindableBase.GetPropertyName(Function() Email)
                Dim passwordProp As String = BindableBase.GetPropertyName(Function() Password)
                Dim confirmPasswordProp As String = BindableBase.GetPropertyName(Function() ConfirmPassword)
                Dim birthdayProp As String = BindableBase.GetPropertyName(Function() Birthday)
                Dim genderProp As String = BindableBase.GetPropertyName(Function() Gender)
                If Equals(columnName, firstNameProp) Then
                    If Equals(FirstName, Nothing) OrElse String.IsNullOrEmpty(FirstName) Then Return String.Format("You cannot leave the {0} field empty.", firstNameProp)
                ElseIf Equals(columnName, lastNameProp) Then
                    If Equals(LastName, Nothing) OrElse String.IsNullOrEmpty(LastName) Then Return String.Format("You cannot leave the {0} field empty.", lastNameProp)
                ElseIf Equals(columnName, emailProp) Then
                    If Equals(Email, Nothing) OrElse String.IsNullOrEmpty(Email) Then Return String.Format("You cannot leave the {0} field empty.", emailProp)
                ElseIf Equals(columnName, passwordProp) Then
                    If Equals(Password, Nothing) OrElse String.IsNullOrEmpty(Password) Then Return String.Format("You cannot leave the {0} field empty.", passwordProp)
                ElseIf Equals(columnName, confirmPasswordProp) Then
                    If Not String.IsNullOrEmpty(Password) AndAlso Not Equals(Password, ConfirmPassword) Then Return "These passwords do not match. Please try again."
                ElseIf Equals(columnName, birthdayProp) Then
                    If Birthday Is Nothing OrElse String.IsNullOrEmpty(Birthday.ToString()) Then Return String.Format("You cannot leave the {0} field empty.", birthdayProp)
                ElseIf Equals(columnName, genderProp) Then
                    If Gender = -1 Then Return String.Format("You cannot leave the {0} field empty.", genderProp)
                End If

                Return Nothing
            End Get
        End Property
    End Class
End Namespace
