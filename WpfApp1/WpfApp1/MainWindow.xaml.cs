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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bt1.Click += bt1_Click;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(input1.Text);
            // fr.Content = new Page1();
            Window w1 = new Window();
            w1.ShowDialog();
            w1.Close();
        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
