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

namespace SNB
{
    public partial class MainPage : PhoneApplicationPage
    {
         public string site;
       // Page1 p1 = new Page1();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            rbfb.IsChecked= true;

        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnproc_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void btnproc_Click(object sender, RoutedEventArgs e)
        {
           if (rbfb.IsChecked == true)
            {
                site = "http://www.facebook.com";
            }
            else if (rbork.IsChecked == true)
            {
                site = "http://www.orkut.com";
            }
            else if (rbtwi.IsChecked == true)
            {
                site = "http://www.twitter.com";
            }
           else if (rblin.IsChecked == true)
           {
               site = "http://www.linkedin.com";
           }
           else
           {
               site = "http://www.bing.com";
           }


          // ApplicationTitle.Text = site;
           string destination = "/Page1.xaml?msg=";

           this.NavigationService.Navigate(new Uri(destination+site, UriKind.Relative));

            
            
            //p1.webbr.Navigate(new Uri(site, UriKind.Absolute));

             
             //webbr.Navigate(new Uri(site, UriKind.Absolute));
        }

        private void rbfb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbork_Checked(object sender, RoutedEventArgs e)
        {
            rbork.IsChecked = true;
        }

        
    }
}