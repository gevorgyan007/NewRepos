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

namespace DynamicContent
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

        private void chkLongText_Checked(object sender, RoutedEventArgs e)
        {
            cmdNext.Content = "Change Name Next";
            cmdBack.Content = "Change Name Back";
        }
        private void chkLongText_Unchecked(object sender, RoutedEventArgs e)
        {
            cmdNext.Content = "Next";
            cmdBack.Content = "Back";
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
