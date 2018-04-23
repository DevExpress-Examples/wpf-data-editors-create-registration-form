Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace RegistrationForm
    Partial Public Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
