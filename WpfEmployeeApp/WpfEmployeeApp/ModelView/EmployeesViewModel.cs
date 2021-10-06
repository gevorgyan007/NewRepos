using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfEmployeeApp.Implimentions;

namespace WpfEmployeeApp.ModelView
{
    public class EmployeesViewModel : BindableBase
    {
        public EmployeesViewModel()
        {
            repository = new Repository();
            var listEmployee = repository.GetAllEmployee().Select(item => new EmployeeViewModel(item)).ToList();
            employees = new ObservableCollection<EmployeeViewModel>(listEmployee);
            
        }

        private IRepository repository;


        private AddressViewModel selectedAddress;
        public AddressViewModel SelectedAddress
        {
            get { return selectedAddress; }
            set { SetProperty(ref selectedAddress, value); }
        }


        private EmployeeViewModel selectedEmployee;

        public EmployeeViewModel SelectedEmployee
        {
            get { return selectedEmployee; }
            set { SetProperty(ref  selectedEmployee ,value); }
        }


        private ObservableCollection<EmployeeViewModel> employees;

       
        public ObservableCollection<EmployeeViewModel> Employees
        {
            get { return employees; }
            set { SetProperty(ref employees, value); }
        }

    }
}
