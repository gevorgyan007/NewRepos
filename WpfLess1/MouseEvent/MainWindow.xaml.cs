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

namespace MouseEvent
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
        private void MouseMove(object sender, MouseEventArgs e) 
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point p = e.GetPosition(rect);
                txtBlock.Text = String.Format($"({p.X};{p.Y}) window cordinate");
            }
           
        }
        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (IsCaptureM.IsChecked==true)
            {
                rect.CaptureMouse();
            }

        }
        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (IsCaptureM.IsChecked == true)
            {
                rect.ReleaseMouseCapture();
            }

        }
    }
}
