using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InkCanvas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public  App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
            this.Activated += new EventHandler(App_Activated);
           // this.Deactivated+= new EventHandler
        }

        private void App_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("------> Activated");
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            Debug.WriteLine("------> Startup");
        }
    }
}
