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
using System.IO.IsolatedStorage;

namespace FinalExam
{
    public partial class ViewCount : PhoneApplicationPage
    {
        string teamADisplay;
        string teamBDisplay;
        
        public ViewCount()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            teamADisplay = (String)IsolatedStorageSettings.ApplicationSettings["teamACounter"];
            teamBDisplay = (String)IsolatedStorageSettings.ApplicationSettings["teamBCounter"];

            countDisplay.Text = "Team A: " + teamADisplay + " vs Team B: " + teamBDisplay;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            //Todo - Call resetScore() from Mainpage.xaml.cs



            
            IsolatedStorageSettings.ApplicationSettings["teamACounter"] = "0";
            IsolatedStorageSettings.ApplicationSettings["teamBCounter"] = "0";
            //This does not reset the score integer. Just the string, so when I clear the score and try to 
            //start counting again, it will start with what the score was before clearing.
            
        }
    }
}