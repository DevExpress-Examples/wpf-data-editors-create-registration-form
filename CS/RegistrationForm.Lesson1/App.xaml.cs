using DevExpress.Xpf.Core;
using System.Windows;

namespace RegistrationForm {
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
