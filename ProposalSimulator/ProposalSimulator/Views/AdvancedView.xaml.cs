namespace ProposalSimulator.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using ProposalSimulator.ViewModels;

    /// <summary>
    ///     Interaction logic for AdvancedView.xaml
    /// </summary>
    public partial class AdvancedView : UserControl
    {
        public AdvancedView()
        {
            InitializeComponent();
            DataContext = new AdvancedViewModel();
        }

        public AdvancedViewModel ViewModel
        {
            get { return DataContext as AdvancedViewModel; }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.GoBack();
        }
    }
}