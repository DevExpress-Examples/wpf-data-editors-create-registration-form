using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using RegistrationForm.DataModel;
using System;

namespace RegistrationForm.ViewModel {
    [POCOViewModel]
    public class RegistrationViewModel {
        public static RegistrationViewModel Create() {
            return ViewModelSource.Create(() => new RegistrationViewModel());
        }
        protected RegistrationViewModel() {
            if(this.IsInDesignMode())
                InitializeInDesignMode();
            else InitializeInRuntime();
        }
        void InitializeInDesignMode() {
            FirstName = "John";
            LastName = "Smith";
            Email = "John.Smith@JohnSmithMail.com";
            Password = "Password";
            ConfirmPassword = "Password";
            Birthday = new DateTime(1980, 1, 1);
            Gender = 1;
        }
        void InitializeInRuntime() {
            Birthday = null;
            Gender = -1;
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string ConfirmPassword { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public virtual int Gender { get; set; }

        public void AddEmployee() {
            EmployeesModelHelper.AddNewEmployee(FirstName, LastName, Email, Password, Birthday.Value, Gender);
        }
    }
}