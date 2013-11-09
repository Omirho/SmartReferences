using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Coding4Fun.Toolkit.Controls;
using My_Buddy.Resources;
using My_Buddy.ViewModels;

namespace My_Buddy
{
    public partial class Add : PhoneApplicationPage
    {
        public Add()
        {
            InitializeComponent();
            p1 = new PhotoChooserTask();
            p1.Completed += new EventHandler<PhotoResult>(p1_Completed);
            p2 = new CameraCaptureTask();
            p2.Completed += new EventHandler<PhotoResult>(p2_Completed);
            item = new ItemViewModel();
        }

        PhotoChooserTask p1;
        CameraCaptureTask p2;
        ItemViewModel item;

        private void newi(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0 || description.Text.Length == 0)
                MessageBox.Show("Please enter valid details");
            else
            {
                p2.Show();
                NavigationService.GoBack();
            }
        }

        private void existing(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0 || description.Text.Length == 0)
                MessageBox.Show("Please enter valid details");
            else
            {
                p1.Show();
                NavigationService.GoBack();
            }
        }

        void p1_Completed(object sender, PhotoResult e)
        {
            item.Path = e.OriginalFileName;
            item.Name = name.Text;
            item.Description = description.Text;
            item.isImage = true;
            App.ViewModel.AddData(item);
            //NavigationService.GoBack();
            //var input = new InputPrompt();
            //input.Completed += new EventHandler<PopUpEventArgs<string,PopUpResult> > (input_Completed);
            //input.Title = "Add Name";
            //input.Message = "";
            //input.Show();
        }

        void p2_Completed(object sender, PhotoResult e)
        {
            item.Path = e.OriginalFileName;
            item.Name = name.Text;
            item.Description = description.Text;
            item.isImage = true;
            App.ViewModel.AddData(item);
            //NavigationService.GoBack();
            //var input = new InputPrompt();
            //input.Completed += new EventHandler<PopUpEventArgs<string, PopUpResult>>(input_Completed);
            //input.Title = "Add Name";
            //input.Message = "";
            //input.Show();
        }

        /*void input_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            item.Name = e.Result;
            App.ViewModel.test(item);
            NavigationService.GoBack();
        }*/
    }
}