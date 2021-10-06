using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeInfo
{
   public class BonusTemplateSeelector: DataTemplateSelector
    {
        public DataTemplate TempIntern { get; set; }
        public DataTemplate TempEmployees { get; set; }
        public DataTemplate TempEmpty { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return TempEmpty;
            }
            if (((Employee)item).Position == PositionType.Intern)
            {
                return TempIntern;
            }
            return TempEmployees;
        }
    }
}
