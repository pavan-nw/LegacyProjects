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

namespace AnalogClock
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            var now = DateTime.Now;
            int dy = now.Day;
            int mn = now.Month;
            int yr = now.Year;
            txtdt.Text = Convert.ToString(dy) + ":" + Convert.ToString(mn) + ":" + Convert.ToString(yr);

            double hran = ((float)now.Hour) / 12 * 360 + now.Minute / 2;

            double minan = ((float)now.Minute) / 60 * 360 + now.Second / 10;

            double secan = ((float)now.Second) / 60 * 360;

        
            
            HourAnimation.From = hran;
            HourAnimation.To = hran + 360;

            MinuteAnimation.From = minan;
            MinuteAnimation.To = minan + 360;

            SecondAnimation.From = secan;
            SecondAnimation.To = secan + 360;

            ClockStoryboard.Begin();
           
        }
      
    }
}