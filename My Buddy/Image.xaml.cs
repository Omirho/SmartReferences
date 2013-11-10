using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace My_Buddy
{
    public partial class Image : PhoneApplicationPage
    {
        public Image()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //var s = PhoneApplicationService.Current.State["img"];
            base.OnNavigatedTo(e);
            string path = "";
            if (NavigationContext.QueryString.TryGetValue("img", out path))
            {
                BitmapImage i = new BitmapImage(new Uri(path, UriKind.Relative));
                image.Source = i;
                //MessageBox.Show(path);
            }
        }
    }
}