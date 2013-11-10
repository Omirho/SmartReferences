using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace My_Buddy
{
    public partial class BaseConverter : PhoneApplicationPage
    {
        public BaseConverter()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void bin_TextChanged(object sender, TextChangedEventArgs e)
        {
            String challowed = "01", lt;
            for (int x = 0; x < bin.Text.Length; x++)
            {
                lt = bin.Text.Substring(x, 1);
                if (!challowed.Contains(lt))
                    bin.Text = bin.Text.Replace(lt, String.Empty);
            }
            bin.Select(bin.Text.Length, 0);
            String b = bin.Text;
            if (b.Length > 0)
            {
                Int64 d = Convert.ToInt64(b, 2);
                dec.Text = d.ToString();
                hex.Text = d.ToString("X");
                oct.Text = Convert.ToString(d, 8);
            }
            else Gotffocus(sender, e);
        }

        private void oct_TextChanged(object sender, TextChangedEventArgs e)
        {
            String challowed = "01234567", lt;
            for (int x = 0; x < oct.Text.Length; x++)
            {
                lt = oct.Text.Substring(x, 1);
                if (!challowed.Contains(lt))
                    oct.Text = oct.Text.Replace(lt, String.Empty);
            }
            oct.Select(oct.Text.Length, 0);
            String b = oct.Text;
            if (b.Length > 0)
            {
                Int64 d = Convert.ToInt64(b, 8);
                dec.Text = d.ToString();
                hex.Text = d.ToString("X");
                bin.Text = Convert.ToString(d, 2);
            }
            else Gotffocus(sender, e);
        }

        private void dec_TextChanged(object sender, TextChangedEventArgs e)
        {
            String b = dec.Text;
            if (b.Length > 0)
            {
                Int64 d = Convert.ToInt64(b);
                oct.Text = Convert.ToString(d, 8);
                hex.Text = d.ToString("X");
                bin.Text = Convert.ToString(d, 2);
            }
            else Gotffocus(sender, e);
        }

        private void hex_TextChanged(object sender, TextChangedEventArgs e)
        {
            String challowed = "0123456789ABCDEF", lt;
            for (int x = 0; x < hex.Text.Length; x++)
            {
                lt = hex.Text.Substring(x, 1);
                if (!challowed.Contains(lt))
                    hex.Text = hex.Text.Replace(lt, String.Empty);
            }
            hex.Select(hex.Text.Length, 0);
            String b = hex.Text;
            if (b.Length > 0)
            {
                Int64 d = Convert.ToInt64(b, 16);
                oct.Text = Convert.ToString(d, 8);
                dec.Text = d.ToString();
                bin.Text = Convert.ToString(d, 2);
            }
            else Gotffocus(sender, e);
        }

        private void Gotffocus(object sender, RoutedEventArgs e)
        {
            if (bin.Text == "Binary")
            {
                bin.Text = "";
                oct.Text = "";
                hex.Text = "";
                dec.Text = "";
            }
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}