using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace RegistrationForm.ViewModel {
    [POCOViewModel]
    public class RegistrationViewModel {
        public static RegistrationViewModel Create() {
            return ViewModelSource.Create(() => new RegistrationViewModel());
        }
        protected RegistrationViewModel() { }
    }
}