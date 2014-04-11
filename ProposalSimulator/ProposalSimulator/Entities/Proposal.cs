namespace ProposalSimulator.Entities
{
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using ProposalSimulator.Annotations;

    public class Proposal : INotifyPropertyChanged
    {
        private long _id;
        private string _name;
        private double _salary;
        private bool _isManager;

        public long Id
        {
            get { return _id; }
            private set {  _id = value; }
        }

        public string Name
        {
            get { return _name; }

            private set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }

            private set { _salary = value; }
        }

        public bool IsManager
        {
            get { return _isManager; }

            private set { _isManager = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }



   
     
    
}