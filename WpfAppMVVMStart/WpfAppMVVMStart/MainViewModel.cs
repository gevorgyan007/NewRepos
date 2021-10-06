using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVMStart
{
    public class MainViewModel
    {
        private string name;
        private List<string> employeeList;

        public MainViewModel()
        {
            Name = "XXXX";
            employeeList = new List<string> { "RRRRR", "KKKKKK" };
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public List<string> EmployeeList 
        {
            set { employeeList = value; }
            get { return employeeList; }
        }
    }
}
