using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDependancyProp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        


        private void buttom1_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(myFirstControl1.Data.ToString());
            //MessageBox.Show();
        }

        private void buttom2_Click(object sender, RoutedEventArgs e)
        {
            text1.Background = Brushes.AliceBlue;
        }

        private void chek1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chek1_Unchecked(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
