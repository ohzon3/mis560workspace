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
using Microsoft.Devices;
using Microsoft.Devices.Sensors;

namespace week8inclass
{
    public partial class MainPage : PhoneApplicationPage
    {
        //Constructor
        public MainPage()
        {
            InitializeComponent();
            _theAccelerometer.CurrentValueChanged += _theAccelerometer_CurrentValueChanged;

            //determine how often you want updates 
            _theAccelerometer.TimeBetweenUpdates = TimeSpan.FromMilliseconds(50);

        }
        Accelerometer _theAccelerometer = new Accelerometer();
        
        private void vibrate_Click(object sender, RoutedEventArgs e)
        {
            VibrateController.Default.Start(TimeSpan.FromMilliseconds(10));
            soundElement.Play();
        }

        



        void _theAccelerometer_CurrentValueChanged(object sender, SensorReadingEventArgs<AccelerometerReading> e)
        {
            var position = e.SensorReading.Acceleration;

            // Update the User Interface 
            Dispatcher.BeginInvoke(() =>
            {
                xValue.Text = "xValue = " + position.X.ToString("0.00");
                yValue.Text = "yValue = " + position.Y.ToString("0.00");
                zValue.Text = "zValue = " + position.Z.ToString("0.00");

            });
        } 

        private void accelStart_Click(object sender, RoutedEventArgs e)
        {
            _theAccelerometer.Start(); 
        }

        private void accelStop_Click(object sender, RoutedEventArgs e)
        {
            _theAccelerometer.Stop(); 
        } 

    }
}