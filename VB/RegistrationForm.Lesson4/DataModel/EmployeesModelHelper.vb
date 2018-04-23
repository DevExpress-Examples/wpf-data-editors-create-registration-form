Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace RegistrationForm.DataModel
    Public NotInheritable Class EmployeesModelHelper

        Private Sub New()
        End Sub

        Private Shared Entities As New EmployeesDBEntities()
        Public Shared Sub AddNewEmployee(ByVal firstName As String, ByVal lastName As String, ByVal email As String, ByVal password As String, ByVal birthday As Date, ByVal gender As Integer)
            Dim emp As Employee = Entities.Employees.Create()
            emp.FirstName = firstName
            emp.LastName = lastName
            emp.Email = email
            emp.Password = password
            emp.Birthday = birthday
            emp.Gender = gender

            Entities.Employees.Add(emp)
            Entities.SaveChanges()
            Messenger.Default.Send(New DBEmployeesChangedMessage())
        End Sub
        Public Shared Function GetEmployees() As List(Of Employee)
            Return Entities.Employees.ToList()
        End Function
    End Class
    Public Class DBEmployeesChangedMessage
    End Class
End Namespace
