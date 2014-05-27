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

namespace Assignment2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/EditNotes.xaml", UriKind.Relative));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //GO to the EditNotes page and show the selected item
            //TODO 
            NavigationService.Navigate(new Uri("/EditNotes.xaml", UriKind.Relative));
        }
    }
}