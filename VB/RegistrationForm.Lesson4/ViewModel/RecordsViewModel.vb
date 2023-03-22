Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports RegistrationForm.DataModel
Imports System.Collections.Generic

Namespace RegistrationForm.ViewModel

    <POCOViewModel>
    Public Class RecordsViewModel

        Public Shared Function Create() As RecordsViewModel
            Return ViewModelSource.Create(Function() New RecordsViewModel())
        End Function

        Protected Sub New()
            Call Messenger.Default.Register(Me, New System.Action(Of DBEmployeesChangedMessage)(AddressOf OnDBEmployeesChanged))
            Employees = New List(Of Employee)()
            If Not IsInDesignMode() Then InitializeEmployees()
        End Sub

        Private Sub InitializeEmployees()
            Employees = GetEmployees()
        End Sub

        Private Sub OnDBEmployeesChanged(ByVal message As DBEmployeesChangedMessage)
            InitializeEmployees()
        End Sub

        Public Overridable Property Employees As List(Of Employee)
    End Class
End Namespace
