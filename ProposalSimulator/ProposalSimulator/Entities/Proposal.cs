namespace ProposalSimulator.Entities
{
    public class Proposal : BaseObject
    {
        private long _id;
        private bool _isManager;
        private string _name;
        private double _salary;

        public long Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public double Salary
        {
            get { return _salary; }

            set
            {
                _salary = value;
                NotifyPropertyChanged("Salary");
            }
        }

        public bool IsManager
        {
            get { return _isManager; }

            set
            {
                _isManager = value;
                NotifyPropertyChanged("IsManager");
            }
        }
<<<<<<< HEAD
    }
=======

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }



   
     
    
>>>>>>> 19f4e447d2ae509d9717f18f33833c87ac4778a0
}