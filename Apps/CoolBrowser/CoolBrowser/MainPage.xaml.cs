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

namespace CoolBrowser
{
    public partial class MainPage : PhoneApplicationPage
    {
        public string site ;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            
        }

        private void btngo_Click(object sender, RoutedEventArgs e)
        {
            site = txturl.Text;
            
            if(site.Contains("http://"))
            {
            }
            else{
                site="http://"+txturl.Text;
            }

            webbr.Navigate(new Uri(site, UriKind.Absolute));
        }
    }
}