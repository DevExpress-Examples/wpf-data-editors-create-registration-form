Imports System.Collections.Generic

Namespace RegistrationForm.DataModel
    Public Class Gender
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Private Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Private privateDescription As String
        Public Property Description() As String
            Get
                Return privateDescription
            End Get
            Private Set(ByVal value As String)
                privateDescription = value
            End Set
        End Property
        Public Sub New(ByVal id As Integer, ByVal description As String)
            Me.ID = id
            Me.Description = description
        End Sub
    End Class
    Public Class GenderList
        Inherits List(Of Gender)

        Private Shared privateSource As GenderList
        Public Shared Property Source() As GenderList
            Get
                Return privateSource
            End Get
            Private Set(ByVal value As GenderList)
                privateSource = value
            End Set
        End Property

        Shared Sub New()
            Source = New GenderList()
            Source.Add(New Gender(0, "Female"))
            Source.Add(New Gender(1, "Male"))
        End Sub
    End Class
End Namespace
