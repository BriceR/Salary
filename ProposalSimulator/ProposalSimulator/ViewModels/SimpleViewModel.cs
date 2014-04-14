using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using ProposalSimulator.Controls;
using ProposalSimulator.Controls.Inputs;
using ProposalSimulator.Entities;

namespace ProposalSimulator.ViewModels
{
    public class SimpleViewModel
    {
        private readonly Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;

        public SimpleViewModel()
        {
            Proposals = new ObservableCollection<Proposal>();

            AddCommand = new RelayCommand(p => AddProposal(), p => CanExecuteAddCmd());
            NavigateCommand = new RelayCommand(p => Navigate(), p => CanExecuteNavigateCmd());
        }

        public ICommand AddCommand { get; set; }
        public ICommand NavigateCommand { get; set; }

        public bool CanExecuteAddCmd()
        {
            return true;
        }
        public bool CanExecuteNavigateCmd()
        {
            return true;
        }

        public void AddProposal()
        {
            _dispatcher.BeginInvoke(new Action(() => { Proposals.Add(new Proposal { Id = 23, Name = "sample", IsManager = (Proposals.Count%2==0) ? true :false, Salary = 125000.34 }); }));
        }

        public ObservableCollection<Proposal> Proposals { get; set; }

        public static event NeedToChangeContentHandler NeedToChangeContent;

        private void ChangeContentEvent(object o, NeedToChangeContentEventArg e)
        {
            if (NeedToChangeContent != null)
                NeedToChangeContent(o, e);
        }

        public void Navigate()
        {
            var evt = new NeedToChangeContentEventArg("AdvancedView");
            ChangeContentEvent(this, evt);
        }
    }
}