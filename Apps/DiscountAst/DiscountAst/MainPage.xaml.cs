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

namespace DiscountAst
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
            try
            {

                double x = Convert.ToDouble(txtamt.Text);
                double y = Convert.ToDouble(txtrate.Text);
                double bamt;
                bamt = (x * y) / 100;
                txtdisamt.Text = Convert.ToString(bamt) + " Rs";
                txtnet.Text = Convert.ToString(x - bamt) + " Rs";
                txtst.Text = "Status: Success";
            }
            catch (Exception e1)
            {
                txtamt.Text = "";
                txtrate.Text = "";
                txtst.Text = "Status: Fail";
                return;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            txtamt.Text = "0";
            txtdisamt.Text = "-- Rs";
            txtnet.Text = "-- Rs";
            txtrate.Text = "0";
            txtst.Text = "Status :";
        }

        private void txtamt_GotFocus(object sender, RoutedEventArgs e)
        {
            txtamt.Text = "";
         //   txtrate.Text = "";
        }

        private void txtrate_GotFocus(object sender, RoutedEventArgs e)
        {
           // txtamt.Text = "";
            txtrate.Text = "";
        }
    }
}