using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using My_Buddy.ViewModels;
using System.Collections.ObjectModel;

namespace My_Buddy
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PhoneApplicationService.Current.State["img"] = "swap";
            NavigationService.Navigate(new Uri("/Image.xaml", UriKind.Relative));
            //MessageBox.Show("yo");
        }

        private void add(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lls.SelectedItem == null)
                return;
            //MessageBox.Show("Done");
            var itm = (lls.SelectedItem as ItemViewModel);
            itm.setused();
            if (App.ViewModel.LastUsed1.Contains(itm))
                App.ViewModel.LastUsed1.Remove(itm);
            while (App.ViewModel.LastUsed1.Count > 7)
                App.ViewModel.LastUsed1.RemoveAt(App.ViewModel.LastUsed1.Count - 1);
            //App.ViewModel.LastUsed1 = new ObservableCollection<ItemViewModel>(App.ViewModel.LastUsed1.OrderByDescending(i => i.LastUsed));
            App.ViewModel.LastUsed1.Insert(0, itm);
            if (itm.isImage == false)
            {
                itm.LastUsed = DateTime.Now;
                NavigationService.Navigate(new Uri(itm.Path, UriKind.Relative));
            }
            lls.SelectedItem = null;
        }
    }
}