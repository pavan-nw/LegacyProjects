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

using System.Text;


namespace calci1
{
    public partial class MainPage : PhoneApplicationPage
    {
                // Constructor

       public double x, y,res;
       public string choice;
           

        public MainPage()
        {
            InitializeComponent();
        }

        private void ellipse1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e) 
        {

            textBox1.Text = string.Concat(textBox1.Text, "1");
            x = Convert.ToDouble(textBox1.Text);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "2");
            x = Convert.ToDouble(textBox1.Text);

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "3");
            x = Convert.ToDouble(textBox1.Text);

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "4");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "5");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "6");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "7");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "8");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "9");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
                y=x;
            x=0;
            choice="+";
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            switch (choice)
            {
                case "+":
                    res = y + x;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "-":
                    res = y-x;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "*":
                    res = y * x;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "/":
                    if (x != 0)
                    {
                        //res = y / x;
                        textBox1.Text = Convert.ToString(res);
                    }

                   
                    break;
                case "^":
                    res = Math.Pow(y,x);
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "%":
                    res = Math.IEEERemainder(y,x);
                    textBox1.Text = Convert.ToString(res);
                    break;
               
 
            }
            x = res;
            
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text, "0");
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                
                //textBox1.Text = "";
                return;
            }
            else  if(textBox1.Text=="")
            {
                textBox1.Text="0";
            }
             
            textBox1.Text = string.Concat(textBox1.Text, ".");
                        
            x = Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            x = 0;
            choice = "-";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            x = 0;
            choice = "*";
           // button12_Click(object sender, RoutedEventArgs e);
                
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            x = 0;
            choice = "/";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            x = 0;
            choice = "^";
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            x = 0;
            choice = "%";
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
              y = y * Math.PI / 180;
                    res = Math.Sin(y);
                    textBox1.Text = Convert.ToString(res);
                    
            

        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            y = y * Math.PI / 180;
            res = Math.Cos(y);
            textBox1.Text = Convert.ToString(res);
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            y = y * Math.PI / 180;
            res = Math.Tan(y);
            textBox1.Text = Convert.ToString(res);
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
            res = Math.Log10(y);
            textBox1.Text = Convert.ToString(res);
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            y = x;
           
            res = Math.Sqrt(y);
            textBox1.Text = Convert.ToString(res);
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            res = Math.PI;
            textBox1.Text = Convert.ToString(res);
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        


        

        
    }
}