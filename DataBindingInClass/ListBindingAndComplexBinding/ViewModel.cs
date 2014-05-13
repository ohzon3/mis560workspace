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

        private string _SelectedItem;

        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                NotifyPropertyChanged("SelectedItem");
                
            }
        }
       
        //TODO add a property for when we select an item from my list to update the textbox

        //private string _TextboxString;

        //public string TextboxString
        //{
        //    get { return _TextboxString; }
        //    set
        //    {
        //        _TextboxString = value;
        //        NotifyPropertyChanged("TexboxString");
        //    }
        //}

        #region Command logic
        public ICommand ButtonCommand
        {
            get
            {
                return new DelegateCommand(SetToList, CanSetToList); 
                //must pass these two things, can name them anything
                //
            }

        }

        private void SetToList(object obj)
        {
            MyList.Add(SelectedItem);
            
        }

        private bool CanSetToList(object obj)
        {
            //always set to true for now
            return true;
        }

        #endregion

    }
}
