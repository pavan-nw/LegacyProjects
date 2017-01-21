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
    public partial class Page1 : PhoneApplicationPage
    {
        string seq = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int[] numseq = new int[] { 1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26 };

        string upname;
        string[] msgs = new string[] { "You are Sad", "Your Work will be success", "You ll get surprise" ,"You will be on journey soon", "You luck depends on your friend. Take Care of your friend",
        "You are good learner", "You ll be giving party today", "Today is bit unlucky for you","You are Cool and smart person","Please control your stupidity today","Nice name, Nice personality","Fast and Furious Day","Danger.! Don't ride vehicle today",
        "Someone is loving you in your hangouts","Be careful while driving","You are very tired","You are in love","Naughty Person, Eating Time","You are very angry.. Be Cool","Your Facebook ac is Hacked. Don't worry Its dream",
        "Study Time.! Go and Have nice reading","Very Sleepy.","No mood to chat:-(","You ll be earning money soon","You are about to become great personality",
        "You are proud of yourself","Time to have Sleep","Very Dull Day. Lazy Person","Clever..!Business Minded","Hard Worker.. Lucky"


        };
        Random r = new Random();
        Random s = new Random();
        int sum=0;
           // A B C D E F G H I J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z
           // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26

        public Page1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string name1 = "";
            
            if (NavigationContext.QueryString.TryGetValue("msg", out name1))
            {
                upname = name1.ToUpper();
                textBlock1.Text = "Hello " + name1+" your luck status is..";

                for (int i = 0; i < upname.Length; i++)
                {
                    for (int j = 0; j < seq.Length; j++)
                    {
                        if (upname[i].Equals(seq[j]))
                        {
                            sum = sum + numseq[j];
                            break;
                        }
                    }
                }
                
               
               
                
                int lno=r.Next(99);
                if (sum == 0) textBlock3.Text = textBlock3.Text + "0%";
                else textBlock3.Text = textBlock3.Text + lno+"%";
                int mrno = r.Next(21);
                sum = sum + mrno;
                sum = sum % 21;
                textBlock2.Text = msgs[sum];
            }
        }
    }
}