using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace RegistrationForm.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }
        protected MainViewModel() { }
    }
}