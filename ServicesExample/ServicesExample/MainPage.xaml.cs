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
using Newtonsoft.Json;

namespace ServicesExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Create the client 
            WebClient client = new WebClient();

            // Handle the event 
            client.DownloadStringCompleted += (s, e) =>
            {
                // Make sure the process completed successfully 
                if (e.Error == null)
                {
                    // Use the result 
                    string jsonResult = e.Result;

                    TimeZone recreated = JsonConvert.DeserializeObject<TimeZone>(jsonResult);
                    textBlock1.Text = recreated.timeZoneName;

                }
            };

            // Start the execution 
            client.DownloadStringAsync(new Uri("https://maps.googleapis.com/maps/api/timezone/json?location=39.6034810,-119.6822510&timestamp=1331161200&sensor=false")); 

        }
    }
}