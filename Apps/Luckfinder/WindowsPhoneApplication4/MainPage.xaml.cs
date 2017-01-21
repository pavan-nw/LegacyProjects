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

namespace WindowsPhoneApplication4
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string destination = "/Page1.xaml?msg=";

            string name = textBox1.Text;
            if (textBox1.Text.Length == 0) textBlock3.Text = "Wait, Let me know your name first.";
            else
            {
                this.NavigationService.Navigate(new Uri(destination + name, UriKind.Relative));
                textBlock3.Text = "*****";
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBlock3.Text = "*****";
        }
    }
}