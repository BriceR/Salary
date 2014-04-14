using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ProposalSimulator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
           Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
           Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
           
        }

        public static void Restart()
        {
        }
    }
}
