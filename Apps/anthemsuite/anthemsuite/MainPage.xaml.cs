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

namespace anthemsuite
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock1.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));

        }

        private void textBlock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock2.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        private void textBlock3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock3.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        private void textBlock4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock4.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));

        }

        private void textBlock5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock5.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));

        }

        private void textBlock6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock6.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        private void textBlock7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock7.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));

        }

        private void textBlock8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock8.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));

        }

        private void textBlock9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock9.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        private void textBlock11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock11.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        private void textBlock10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string country = textBlock10.Text;
            string destination = "/Page1.xaml?msg=";

            this.NavigationService.Navigate(new Uri(destination + country, UriKind.Relative));
        }

        
        


       
    }
}