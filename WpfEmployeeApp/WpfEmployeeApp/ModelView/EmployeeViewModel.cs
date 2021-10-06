using DataAccessLayer.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEmployeeApp.ModelView
{
    public class EmployeeViewModel : BindableBase
    {
        private Employee employee;

        public Employee Employee
        {
            get => employee; set => SetProperty(ref employee, value);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Address> Addresses { get; set; }

        public EmployeeViewModel(Employee employee)
        {
            this.employee = employee;

            this.FirstName = employee.FirstName;
            this.LastName = employee.LastName;
            this.Age = employee.Age;
            this.Addresses = employee.Addresses;
        }

    }
}
