
using System.Windows;

namespace WpfEmployeeApp.ModelView
{
    public class GeneralViewModel : FrameworkElement
    {


        public EmployeeViewModel MyProperty
        {
            get { return (EmployeeViewModel)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(EmployeeViewModel), typeof(GeneralViewModel), new PropertyMetadata(0));


    }
}
