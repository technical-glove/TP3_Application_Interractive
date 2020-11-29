﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TP3.Views
{
    /// <summary>
    /// Interaction logic for AffichageArgent.xaml
    /// </summary>
    public partial class AffichageArgent : INotifyPropertyChanged
    {
        private int _argentCourant = 0;
        public int ArgentCourant
        {
            get { return _argentCourant; }
            set
            {
                if (_argentCourant != value)
                {
                    _argentCourant = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public AffichageArgent()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
