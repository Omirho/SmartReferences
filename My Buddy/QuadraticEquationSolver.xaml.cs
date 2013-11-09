using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Smart_References
{
    public partial class QuadraticEquationSolver : PhoneApplicationPage
    {
        public QuadraticEquationSolver()
        {
            InitializeComponent();
        }

        private void solve_Click_1(object sender, RoutedEventArgs e)
        {
            string aa = a.Text;
            string bb = b.Text;
            string cc = c.Text;

            if (aa.Length == 0 || bb.Length == 0 || cc.Length == 0)
            {
                x1.Text = "";
                x2.Text = "";
                d.Text = "Please enter all parameters";
                return;
            }

            double aaa = Double.Parse(aa);
            double bbb = Double.Parse(bb);
            double ccc = Double.Parse(cc);
            double ddd = bbb * bbb - 4 * aaa * ccc;
            if (ddd >= 0)
            {
                x1.Text = "x1 = " + ( - bbb + Math.Sqrt(ddd)) / ( 2 * aaa);
                x2.Text = "x1 = " + ( - bbb + Math.Sqrt(ddd)) / ( 2 * aaa);
            }
            else
            {
                x1.Text = "x1 = " + (-bbb / (2 * aaa)) + " + " + (Math.Sqrt(-ddd) / (2 * aaa)) + " i";
                x2.Text = "x2 = " + (-bbb / (2 * aaa)) + " - " + (Math.Sqrt(-ddd) / (2 * aaa)) + " i";
            }
            d.Text = "Discriminant = " + ddd;
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            x1.Text = "";
            x2.Text = "";
            d.Text = "";
        }
    }
}