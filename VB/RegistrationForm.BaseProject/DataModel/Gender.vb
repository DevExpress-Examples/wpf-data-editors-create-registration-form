Imports System.Collections.Generic

Namespace RegistrationForm.DataModel

    Public Class Gender

        Private _ID As Integer, _Description As String

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Private Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return _Description
            End Get

            Private Set(ByVal value As String)
                _Description = value
            End Set
        End Property

        Public Sub New(ByVal id As Integer, ByVal description As String)
            Me.ID = id
            Me.Description = description
        End Sub
    End Class

    Public Class GenderList
        Inherits List(Of Gender)

        Private Shared _Source As GenderList

        Public Shared Property Source As GenderList
            Get
                Return _Source
            End Get

            Private Set(ByVal value As GenderList)
                _Source = value
            End Set
        End Property

        Shared Sub New()
            Source = New GenderList()
            Call Source.Add(New Gender(0, "Female"))
            Call Source.Add(New Gender(1, "Male"))
        End Sub
    End Class
End Namespace
