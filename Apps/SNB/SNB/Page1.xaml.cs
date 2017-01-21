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
    public partial class Page1 : PhoneApplicationPage
    {
        MainPage m = new MainPage();
        string site1 = "http://www.google.com";
        public Page1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           //site1 = m.site;
           
            string msg="";
           if (NavigationContext.QueryString.TryGetValue("msg", out msg))
           {
               site1 = msg;
               //ApplicationTitle.Text = site1;
           }


          /*  if (m.rbfb.IsChecked == true)
            {
                site = "http://www.facebook.com";
            }
            else if (m.rbork.IsChecked == true)
            {
                site = "http://www.orkut.com";
            }
            else if (m.rbtwi.IsChecked == true)
            {
                site = "http://www.twitter.com";
            }
            else if (m.rblin.IsChecked == true)
            {
                site = "http://www.linkedin.com";
            }*/
            webbr.Navigate(new Uri(site1, UriKind.Absolute));
        }
    }
}