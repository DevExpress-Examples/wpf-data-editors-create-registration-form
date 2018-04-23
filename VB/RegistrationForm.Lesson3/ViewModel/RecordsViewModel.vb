Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports RegistrationForm.DataModel
Imports System.Collections.Generic

Namespace RegistrationForm.ViewModel
    <POCOViewModel> _
    Public Class RecordsViewModel
        Public Shared Function Create() As RecordsViewModel
            Return ViewModelSource.Create(Function() New RecordsViewModel())
        End Function
        Protected Sub New()
            Messenger.Default.Register(Of DBEmployeesChangedMessage)(Me, AddressOf OnDBEmployeesChanged)
            Employees = New List(Of Employee)()
            If Not Me.IsInDesignMode() Then
                InitializeEmployees()
            End If
        End Sub
        Private Sub InitializeEmployees()
            Employees = EmployeesModelHelper.GetEmployees()
        End Sub
        Private Sub OnDBEmployeesChanged(ByVal message As DBEmployeesChangedMessage)
            InitializeEmployees()
        End Sub

        Public Property Employees() As List(Of Employee)
    End Class
End Namespace