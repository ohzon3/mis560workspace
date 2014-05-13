using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;    //Needed for Notify property change
using System.Collections.ObjectModel; //for observable collection

namespace TemplatingAndBinding
{
    public class MyClass : INotifyPropertyChanged 
    {
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

        private int _NumberOfClicks = 0;

        public int NumberOfClicks
        {
            get { return _NumberOfClicks; }
            set
            {
                _NumberOfClicks = value;
                NotifyPropertyChanged("NumberOfClicks");
            }
        }
    }
}
