Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Linq

Namespace RegistrationForm.DataModel

    Public Module EmployeesModelHelper

        Private Entities As EmployeesDBEntities = New EmployeesDBEntities()

        Public Sub AddNewEmployee(ByVal firstName As String, ByVal lastName As String, ByVal email As String, ByVal password As String, ByVal birthday As Date, ByVal gender As Integer)
            Dim emp As Employee = Entities.Employees.Create()
            emp.FirstName = firstName
            emp.LastName = lastName
            emp.Email = email
            emp.Password = password
            emp.Birthday = birthday
            emp.Gender = gender
            Entities.Employees.Add(emp)
            Call Entities.SaveChanges()
            Call Messenger.Default.Send(New DBEmployeesChangedMessage())
        End Sub

        Public Function GetEmployees() As List(Of Employee)
            Return Entities.Employees.ToList()
        End Function
    End Module

    Public Class DBEmployeesChangedMessage
    End Class
End Namespace
