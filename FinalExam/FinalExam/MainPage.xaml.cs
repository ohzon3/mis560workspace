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
    public partial class MainPage : PhoneApplicationPage
    {

        int teamAScore = 0;
        int teamBScore = 0;
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonViewCount_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewCount.xaml", UriKind.Relative));
        }

        private void buttonTeamA_Click(object sender, RoutedEventArgs e)
        {
            teamAScore++;
            IsolatedStorageSettings.ApplicationSettings["teamACounter"] = teamAScore.ToString();
        }

        private void buttonTeamB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}