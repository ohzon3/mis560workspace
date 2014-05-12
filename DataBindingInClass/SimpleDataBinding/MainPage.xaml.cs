using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.ComponentModel;    //Needed for Notify property change

namespace SimpleDataBinding
{
    public partial class MainPage : PhoneApplicationPage, INotifyPropertyChanged 
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private string _MyString = String.Empty;
        //private string _MyString = "To show how binding is initialy set";

        public string MyString
        {
            get
            {
                return _MyString;
            }
            set
            {
                _MyString = value;
                NotifyPropertyChanged("MyString"); //The Must use the name of the property
            }


        }


        #region Notify Property logic
        public event PropertyChangedEventHandler PropertyChanged;

        // NotifyPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}