using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInfo
{
    public class EmployeeList : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>
        {
            new Employee("Vahan","Grigoryan",25,PositionType.Accountant),
            new Employee("Karen","Arayan",25,PositionType.ProjectManager),
            new Employee("Vahag","Grigoryan",25,PositionType.Intern)
        };

        public Dictionary<PositionType, string> BonusAmount { get; } = new Dictionary<PositionType, string> { { PositionType.Intern, "0%" },
                                                                                                                { PositionType.Developer, "30%" },
                                                                                                                { PositionType.Accountant ,"20%" },
                                                                                                                { PositionType.ProjectManager, "40%" } };

        public string FName { get; set; }
        public string LName { get; set; }
        public int Age1 { get; set; }

        public PositionType Position1
        {
            get { return position1; }
            set
            {
                if (position1 != value)
                {
                    position1 = value; 
                    OnPropertyChanged("Position1");
                }
            }
        }

        public Employee EmployeeSelect
        {
            get => employeeSelect;
            set => SetProperty(value, ref employeeSelect);
        }

        public string BonusP
        {
            get
            {
                return BonusAmount[EmployeeSelect.Position];
            }

        }


        private Array myEnumArray;
        private PositionType position1;
        private Employee employeeSelect;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ICommand AddNewEmployee { get; }
        public ICommand RemoveEmployee { get; }


        public Array MyEnumArray
        {
            get { return Enum.GetValues(typeof(PositionType)); }
        }

        public EmployeeList()
        {
            AddNewEmployee = new MyCommand(AddHandler, null);
            RemoveEmployee = new MyCommand(RemoveHandler, null);

        }



        private void RemoveHandler(object obj)
        {
            Employees.Remove(EmployeeSelect);
        }

        private void AddHandler(object obj)
        {
            Employees.Add(new Employee(FName, LName, Age1, Position1));
        }


        #region MVVM

        public void SetProperty<T>(T value, ref T employeeSelect, [CallerMemberName] string propertyName = "")
        {
            if (employeeSelect.Equals(value)) return;

            employeeSelect = value;

            OnPropertyChanged(propertyName);
        }

        #endregion
    }

    public class MyCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public MyCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute ?? (Func<object, bool>)((object t) => true);
        }

        public bool CanExecute(object parameter)
        {
            return canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
