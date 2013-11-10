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
    public partial class LinearSystemInTwoVariablesSolver : PhoneApplicationPage
    {
        public LinearSystemInTwoVariablesSolver()
        {
            InitializeComponent();
        }

        private void solve_Click_1(object sender, RoutedEventArgs e)
        {
            string aa1 = a1.Text;
            string bb1 = b1.Text;
            string cc1 = c1.Text;
            string aa2 = a2.Text;
            string bb2 = b2.Text;
            string cc2 = c2.Text;

            if (aa1.Length == 0 || bb1.Length == 0 || cc1.Length == 0 || aa2.Length == 0 || bb2.Length == 0 || cc2.Length == 0)
            {
                x.Text = "";
                y.Text = "";
                d.Text = "Please enter all parameters";
                return;
            }

            double aaa1 = Double.Parse(aa1);
            double bbb1 = Double.Parse(bb1);
            double ccc1 = Double.Parse(cc1);
            double aaa2 = Double.Parse(aa2);
            double bbb2 = Double.Parse(bb2);
            double ccc2 = Double.Parse(cc2);

            x.Text = "x = " + (-bbb1 * ccc2 + bbb2 * ccc1) / (aaa1 * bbb2 - aaa2 * bbb1);
            y.Text = "y = " + (aaa1 * ccc2 - aaa2 * ccc1) / (aaa1 * bbb2 - aaa2 * bbb1);
            d.Text = "";
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
            a1.Text = "";
            b1.Text = "";
            c1.Text = "";
            a2.Text = "";
            b2.Text = "";
            c2.Text = "";
            x.Text = "";
            y.Text = "";
            d.Text = "";
        }
    }
}