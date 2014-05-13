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
using System.Collections.ObjectModel;


namespace TemplatingAndBinding
{
    public class ViewModel : INotifyPropertyChanged 
    {
        //TODO We need to set up the screen to have a list of 5 items each item has a button, and a textbox with the number of times the button was clicked. and a button at the
        //Bottom of the screen that will add another item to the list with 0 clicks.


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

        ObservableCollection<MyClass> MyList = new ObservableCollection<MyClass>();

        public ViewModel()
        {
            MyList.Add(new MyClass());
            MyList.Add(new MyClass());
            MyList.Add(new MyClass());
            MyList.Add(new MyClass());
            MyList.Add(new MyClass());
        }

    }
}
