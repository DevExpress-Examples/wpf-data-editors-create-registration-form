Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace RegistrationForm

    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            Call ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
