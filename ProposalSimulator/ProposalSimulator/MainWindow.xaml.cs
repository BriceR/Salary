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

namespace ProposalSimulator
{
    using ProposalSimulator.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContentControl.Content = FindResource("SimpleView");
            AdvancedViewModel.NeedToChangeContent += AdvancedViewModel_NeedToChangeContent;
            SimpleViewModel.NeedToChangeContent += SimpleViewModel_NeedToChangeContent;
        }

        void SimpleViewModel_NeedToChangeContent(object o, Controls.NeedToChangeContentEventArg e)
        {
            MainContentControl.Content = FindResource("AdvancedView");
        }

        void AdvancedViewModel_NeedToChangeContent(object o, Controls.NeedToChangeContentEventArg e)
        {
            MainContentControl.Content = FindResource("SimpleView");
        }
    }
}
