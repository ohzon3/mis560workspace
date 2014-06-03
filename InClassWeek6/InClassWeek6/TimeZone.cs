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

namespace InClassWeek6
{
    public class TimeZone
    {
        public double dstOffset {get; set;}
        public double rawOffset {get; set;}
        public string status {get; set;}
        public string timeZoneId {get; set;}
        public string timeZoneName {get; set;}
    }
}
