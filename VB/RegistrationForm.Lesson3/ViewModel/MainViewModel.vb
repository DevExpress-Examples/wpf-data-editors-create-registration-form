Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace RegistrationForm.ViewModel
    <POCOViewModel> _
    Public Class MainViewModel
        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function
        Protected Sub New()
        End Sub
    End Class
End Namespace