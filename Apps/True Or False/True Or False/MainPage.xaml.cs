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

namespace True_Or_False
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor

        int num=1,flag=0;
        Random r = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            
            num=r.Next(99999);
            txtblkst.Text = Convert.ToString(num)+" is a Prime number (choose true or false)";
            btnstart.IsEnabled = false;
            btnchk.IsEnabled = true;
            btnnext.IsEnabled = true;
        }

        private void btnchk_Click(object sender, RoutedEventArgs e)
        {
            flag = 0;
            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                   // return;
                    break;
                }
            }

            if (flag == 0)
            {//num is prime
                if (rdbtrue.IsChecked==true)
                {
                    txtblkres.Text = "Congratulations..! You Are Correct";
                }
                if (rdbfalse.IsChecked == true)
                {
                    txtblkres.Text = "Sorry..! You Are Wrong";
                }
            }
            else if (flag == 1)
            {//num is not prime
                if (rdbfalse.IsChecked == true)
                {
                    txtblkres.Text = "Congratulations..! You Are Correct";
                }
                if (rdbtrue.IsChecked == true)
                {
                    txtblkres.Text = "Sorry..! You Are Wrong";
                }
            }

        }

        private void btnnext_Click(object sender, RoutedEventArgs e)
        {
            num = r.Next(99999);
            txtblkst.Text = Convert.ToString(num) + " is a Prime number (choose true or false)";
        }

    }
}