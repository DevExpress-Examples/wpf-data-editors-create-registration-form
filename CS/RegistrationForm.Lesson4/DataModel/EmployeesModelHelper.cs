using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationForm.DataModel {
    public static class EmployeesModelHelper {
        static EmployeesDBEntities Entities = new EmployeesDBEntities();
        public static void AddNewEmployee(string firstName, string lastName, string email, string password, DateTime birthday, int gender) {
            Employee emp = Entities.Employees.Create();
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.Email = email;
            emp.Password = password;
            emp.Birthday = birthday;
            emp.Gender = gender;

            Entities.Employees.Add(emp);
            Entities.SaveChanges();
            Messenger.Default.Send(new DBEmployeesChangedMessage());
        }
        public static List<Employee> GetEmployees() {
            return Entities.Employees.ToList();
        }
    }
    public class DBEmployeesChangedMessage { }
}
