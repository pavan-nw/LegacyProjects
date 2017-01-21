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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

         public double x, y, z, res;
       public string choice;
       float m, n, p;
      
        
        private void cone_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = true;
            c.IsEnabled = false;
            a.Text = "radius";
            b.Text = "height";
            choice = "cone";
          
        }

        private void rstbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (choice)
                {
                    case "cone":
                        x = Convert.ToDouble(a.Text);
                        y = Convert.ToDouble(b.Text);

                        res = (Math.PI * (x * x) * y) * (0.3333333333);
                        break;
                    case "cyl":
                        x = Convert.ToDouble(a.Text);
                        y = Convert.ToDouble(b.Text);
                        m = (float)x;
                        n = (float)y;
                        res = Math.PI * m * n * m;
                        break;
                    case "spr":
                        x = Convert.ToDouble(a.Text);

                        m = (float)x;

                        res = 1.333333 * m * m * m * Math.PI;
                        break;
                    case "pyr":
                        x = Convert.ToDouble(a.Text);
                        y = Convert.ToDouble(b.Text);
                        z = Convert.ToDouble(c.Text);
                        m = (float)x;
                        n = (float)y;
                        p = (float)z;
                        res = m * n * p * 0.33333333;
                        break;
                    case "cube":
                        x = Convert.ToDouble(a.Text);
                        // y = Convert.ToDouble(b.Text);
                        m = (float)x;
                        // n = (float)y;
                        res = m * m * m;
                        break;
                    case "tetra":
                        x = Convert.ToDouble(a.Text);

                        m = (float)x;

                        res = Math.Sqrt(2) * m * m * m * 0.0833333;
                        break;
                    case "cuboid":
                        x = Convert.ToDouble(a.Text);
                        y = Convert.ToDouble(b.Text);
                        z = Convert.ToDouble(c.Text);
                        m = (float)x;
                        n = (float)y;
                        p = (float)z;
                        res = m * n * p;
                        break;

                }
            }
            catch (Exception e2)
            {
                area.Text = "Enter Valid Inputs";
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
            a.Text = "radius";
            b.Text="height";
            choice = "cyl";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = false;
            c.IsEnabled = false;
            a.Text = "radius";
            choice = "sph";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            b.IsEnabled = true;
            a.IsEnabled = true;
            c.IsEnabled = true;
            a.Text = "edge1";
            b.Text = "edge2";
            c.Text = "height";
            choice = "pyr";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            b.IsEnabled = false;
            a.IsEnabled = true;
            c.IsEnabled = false;
            a.Text = "edge lengh";
            choice = "cube";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            b.IsEnabled =false;
            a.IsEnabled = true;
            c.IsEnabled = false;
            a.Text = "side";
           
            choice = "tetra";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            b.IsEnabled = true;
            c.IsEnabled = true;
            a.IsEnabled = true;
            a.Text = "edge1";
            b.Text="edge2";
            c.Text = "edge3";
            choice = "cuboid";
        }

        
    }
}