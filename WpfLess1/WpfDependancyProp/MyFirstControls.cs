using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDependancyProp
{
    public class MyFirstControls : FrameworkElement
    {
        public MyFirstControls()
        {

        }
        public static DependencyProperty DataProperty;


        static MyFirstControls()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int),typeof(MyFirstControls));
        }

        public int Data
        {
            get { return (int)GetValue(DataProperty); }
            set { SetValue(DataProperty,value); }
        }

    }
}
