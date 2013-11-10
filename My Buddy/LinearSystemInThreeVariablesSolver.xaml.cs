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
    public partial class LinearSystemInThreeVariablesSolver : PhoneApplicationPage
    {
        public LinearSystemInThreeVariablesSolver()
        {
            InitializeComponent();
        }

        private void solve_Click_1(object sender, RoutedEventArgs e)
        {
            string aa1 = a1.Text;
            string bb1 = b1.Text;
            string cc1 = c1.Text;
            string dd1 = d1.Text;
            string aa2 = a2.Text;
            string bb2 = b2.Text;
            string cc2 = c2.Text;
            string dd2 = d2.Text;
            string aa3 = a3.Text;
            string bb3 = b3.Text;
            string cc3 = c3.Text;
            string dd3 = d3.Text;

            if (aa1.Length == 0 || bb1.Length == 0 || cc1.Length == 0 || dd1.Length == 0 || aa2.Length == 0 || bb2.Length == 0 || cc2.Length == 0 || dd2.Length == 0 || aa3.Length == 0 || bb3.Length == 0 || cc3.Length == 0 || dd3.Length == 0)
            {
                x.Text = "";
                y.Text = "";
                z.Text = "";
                d.Text = "Please enter all parameters";
                return;
            }

            double aaa1 = Double.Parse(aa1);
            double bbb1 = Double.Parse(bb1);
            double ccc1 = Double.Parse(cc1);
            double ddd1 = Double.Parse(dd1);
            double aaa2 = Double.Parse(aa2);
            double bbb2 = Double.Parse(bb2);
            double ccc2 = Double.Parse(cc2);
            double ddd2 = Double.Parse(dd2);
            double aaa3 = Double.Parse(aa3);
            double bbb3 = Double.Parse(bb3);
            double ccc3 = Double.Parse(cc3);
            double ddd3 = Double.Parse(dd3);

            x.Text = "x = " + (det(bbb1, ccc1, ddd1, bbb2, ccc2, ddd2, bbb3, ccc3, ddd3) / det(aaa1, bbb1, ccc1, aaa2, bbb2, ccc2, aaa3, bbb3, ccc3));
            y.Text = "y = " + (-det(aaa1, ccc1, ddd1, aaa2, ccc2, ddd2, aaa3, ccc3, ddd3) / det(aaa1, bbb1, ccc1, aaa2, bbb2, ccc2, aaa3, bbb3, ccc3));
            z.Text = "z = " + (det(aaa1, bbb1, ddd1, aaa2, bbb2, ddd2, aaa3, bbb3, ddd3) / det(aaa1, bbb1, ccc1, aaa2, bbb2, ccc2, aaa3, bbb3, ccc3));
            d.Text = "";
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
            a1.Text = "";
            b1.Text = "";
            c1.Text = "";
            d1.Text = "";
            a2.Text = "";
            b2.Text = "";
            c2.Text = "";
            d2.Text = "";
            a3.Text = "";
            b3.Text = "";
            c3.Text = "";
            d3.Text = "";
            x.Text = "";
            y.Text = "";
            z.Text = "";
            d.Text = "";
        }

        private double det(double a1, double b1, double c1, double a2, double b2, double c2, double a3, double b3, double c3)
        {
            return a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);
        }
    }
}