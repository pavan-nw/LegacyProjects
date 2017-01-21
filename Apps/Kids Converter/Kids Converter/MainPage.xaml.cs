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

namespace Kids_Converter
{
    public partial class MainPage : PhoneApplicationPage
    {
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string bstr="";

            try
            {

                int x = Convert.ToInt32(txtin.Text);

                if (rd2.IsChecked == true)
                {
                    bstr = Convert.ToString(x, 2);
                }
                else if (rd8.IsChecked == true)
                {
                    bstr = Convert.ToString(x, 8);
                }
                else if (rd16.IsChecked == true)
                {
                    bstr = Convert.ToString(x, 16);
                    bstr=bstr.ToUpper();
                }

                txtop.Text = bstr;
                txtin.Text = "";
            }
            catch (Exception e1)
            {
                return;
            }

           
            //textBox2.Text = Convert.ToString(y);

        }
    }
}