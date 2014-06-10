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
using BackgroundAgent;
using Microsoft.Phone.Scheduler;


namespace multitasking
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // A unique name for your task. It is used to 
            // locate it in from the service. 
            var taskName = "MyTask";

            // Create the Task 
            PeriodicTask task = new PeriodicTask(taskName);

            // Description is required 
            task.Description = "This saves some data to Isolated Storage";

            // Add it to the service to execute ScheduledActionService.Add(task); 


        }
    }
}