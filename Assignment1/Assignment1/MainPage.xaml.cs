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
using Microsoft.Phone.Tasks;

namespace Assignment1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            messageOutput.Text = "";

            textBlock1.MouseLeftButtonUp += new MouseButtonEventHandler(textBlock1_MouseLeftButtonUp);
            textBlock2.MouseLeftButtonUp += new MouseButtonEventHandler(textBlock2_MouseLeftButtonUp);
            textBlock3.MouseLeftButtonUp += new MouseButtonEventHandler(textBlock3_MouseLeftButtonUp);
            linkRMU.MouseLeftButtonUp += new MouseButtonEventHandler(linkRMU_MouseLeftButtonUp);
        }

        void linkRMU_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
               WebBrowserTask task = new WebBrowserTask();
               task.Uri = new Uri("http://www.robertmorris.edu", UriKind.Absolute);
               task.Show();
        }
 
        void textBlock1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            messageOutput.Text = "You have clicked " + textBlock1.Name;
        }

        void textBlock2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            messageOutput.Text = "You have clicked " + textBlock2.Name;
        }

        void textBlock3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            messageOutput.Text = "You have clicked " + textBlock3.Name;
        }
    }
}