Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace RegistrationForm.ViewModel

    <POCOViewModel>
    Public Class RegistrationViewModel

        Public Shared Function Create() As RegistrationViewModel
            Return ViewModelSource.Create(Function() New RegistrationViewModel())
        End Function

        Protected Sub New()
        End Sub
    End Class
End Namespace
