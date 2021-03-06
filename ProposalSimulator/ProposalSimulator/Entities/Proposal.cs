﻿namespace ProposalSimulator.Entities
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
    }
}