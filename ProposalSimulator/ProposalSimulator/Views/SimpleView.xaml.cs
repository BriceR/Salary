namespace ProposalSimulator.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using ProposalSimulator.ViewModels;

    /// <summary>
    ///     Interaction logic for SimpleView.xaml
    /// </summary>
    public partial class SimpleView : UserControl
    {
        public SimpleView()
        {
            InitializeComponent();
            DataContext = new SimpleViewModel();
        }

        public SimpleViewModel ViewModel
        {
            get { return DataContext as SimpleViewModel; }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.MoveToAdvanced();
        }
    }
}