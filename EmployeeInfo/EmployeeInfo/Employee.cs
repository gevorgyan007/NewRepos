using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public class Employee : INotifyPropertyChanged
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private PositionType position;
        public PositionType Position
        {
            get { return position; }
            set { position = value; OnPropertyChanged("Position"); }
        }
        public string BonusP { get; set; }



        public Employee(string firstName, string lastName, int age, PositionType position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public Employee()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
    public enum PositionType
    {

        Intern, Developer, ProjectManager, Accountant
    }

}
