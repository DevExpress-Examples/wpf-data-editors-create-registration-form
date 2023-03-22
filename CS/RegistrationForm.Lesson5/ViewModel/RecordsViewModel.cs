using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using RegistrationForm.DataModel;
using System.Collections.Generic;

namespace RegistrationForm.ViewModel {
    [POCOViewModel]
    public class RecordsViewModel {
        public static RecordsViewModel Create() {
            return ViewModelSource.Create(() => new RecordsViewModel());
        }
        protected RecordsViewModel() {
            Messenger.Default.Register<DBEmployeesChangedMessage>(this, OnDBEmployeesChanged);
            Employees = new List<Employee>();
            if(!this.IsInDesignMode())
                InitializeEmployees();
        }
        void InitializeEmployees() {
            Employees = EmployeesModelHelper.GetEmployees();
        }
        void OnDBEmployeesChanged(DBEmployeesChangedMessage message) {
            InitializeEmployees();
        }

        public virtual List<Employee> Employees { get; set; }
    }
}