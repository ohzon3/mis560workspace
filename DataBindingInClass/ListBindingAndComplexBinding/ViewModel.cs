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


namespace ListBindingAndComplexBinding
{
    public class ViewModel : INotifyPropertyChanged 
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

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewModel()
        {
            MyList = new ObservableCollection<string>();
            MyList.Add("Temp");
            MyList.Add("Temp2");
        }

        public ObservableCollection<string> MyList {get;set;}
       
        //TODO add a property for when we select an item from my list to update the textbox

        private string _TextboxString;

        public string TextboxString
        {
            get { return _TextboxString; }
            set
            {
                _TextboxString = value;
                NotifyPropertyChanged("TexboxString");
            }
        }

        #region Command logic
        public ICommand ButtonCommand
        {
            get
            {
                return new DelegateCommand(SetToList, CanSetToList);
            }

        }

        private void SetToList(object obj)
        {
            MyList.Add(TextboxString);
            
        }

        private bool CanSetToList(object obj)
        {
            return true;
        }

        #endregion

    }
}
