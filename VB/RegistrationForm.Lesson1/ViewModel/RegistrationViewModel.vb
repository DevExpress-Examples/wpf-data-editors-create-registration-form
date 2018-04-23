Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace RegistrationForm.ViewModel
    <POCOViewModel> _
    Public Class RegistrationViewModel
        Public Shared Function Create() As RegistrationViewModel
            Return ViewModelSource.Create(Function() New RegistrationViewModel())
        End Function
        Protected Sub New()
        End Sub
    End Class
End Namespace