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

namespace inClassWeek4
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["userName"] = nameTextbox.Text;
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }


    }
}