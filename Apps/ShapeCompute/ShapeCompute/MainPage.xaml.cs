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

namespace ShapeCompute
{
    public partial class MainPage : PhoneApplicationPage
    {
        public double x, y, z, res;
       public string choice;
       float m, n, p;
      
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string destination = "/Page1.xaml";

            this.NavigationService.Navigate(new Uri(destination, UriKind.Relative));
           
           
        }

        private void circle_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = false;
            c.IsEnabled = false;
            a.Text = "radius";
            choice = "circle";
          
        }

        private void rstbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            switch (choice)
            {
                    
                case "circle":
                    x = Convert.ToDouble(a.Text);
                    res = Math.PI * x * x;
                    break;
                case "tri":
                     x = Convert.ToDouble(a.Text);
                     y = Convert.ToDouble(b.Text);
                     m =(float)x;
                     n=(float)y;
                    res = 0.5*m*n;
                    break;
                case "sqr":
                    x = Convert.ToDouble(a.Text);
                    //y = Convert.ToDouble(b.Text);
                    m = (float)x;
                    //n = (float)y;
                    res = m*m;
                    break;
                case "rect":
                    x = Convert.ToDouble(a.Text);
                    y = Convert.ToDouble(b.Text);
                    m = (float)x;
                    n = (float)y;
                    res = m * n;
                    break;
                case "cube":
                    x = Convert.ToDouble(a.Text);
                   // y = Convert.ToDouble(b.Text);
                    m = (float)x;
                   // n = (float)y;
                    res = 6*m;
                    break;
                case "trap":
                    x = Convert.ToDouble(a.Text);
                    y = Convert.ToDouble(b.Text);
                    z = Convert.ToDouble(c.Text);
                    m = (float)x;
                    n = (float)y;
                    p = (float)z;
                    res = 0.5 * (m + n)*p;
                    break;
                    case "cuboid":
                    x = Convert.ToDouble(a.Text);
                    y = Convert.ToDouble(b.Text);
                    z = Convert.ToDouble(c.Text);
                    m = (float)x;
                    n = (float)y;
                    p = (float)z;
                    res = 2*(m*n+n*p+p*m);
                    break;
                    }
            }
        
            catch(Exception e1)
                    {
                area.Text="Enter Valid Inputs";
                return;
            }

            
            area.Text = Convert.ToString(res);
        }

        private void a_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            a.Text = "";
        }

        private void b_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b.Text = "";
        }

        private void c_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            c.Text = "";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
             b.IsEnabled = true;
            a.IsEnabled = true;
            a.Text = "side";
            b.Text="height";
            choice = "tri";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = false;
            c.IsEnabled = false;
            a.Text = "side";
            choice = "sqr";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = true;
            c.IsEnabled = false;
            a.Text = "length";
            b.Text = "breadth";
            choice = "rect";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = false;
            c.IsEnabled = false;
            a.Text = "edge lengh";
            choice = "cube";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = true;
            c.IsEnabled = true;
            a.Text = "parallel side1";
            b.Text = "parallel side2";
                c.Text="distance";
            choice = "trap";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = true;
            c.IsEnabled = true;
            a.Text = "edge1";
            b.Text="edge2";
            c.Text = "edge3";
            choice = "cuboid";
        }

        

        

    }
}