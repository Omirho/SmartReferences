using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Collections.ObjectModel;
using My_Buddy.ViewModels;
using System.Windows.Data;

namespace My_Buddy
{
    public partial class Search : PhoneApplicationPage
    {
        private static readonly IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
        public Search()
        {
            InitializeComponent();
            searchbox.Focus();
            if (appSettings.Contains("All"))
            {
                Items = (ObservableCollection<ItemViewModel>)appSettings["All"];
            }
            else searchbox.Text = "Not Loaded.";
            Data = new CollectionViewSource();
            Data.Source = Items;
            Data.View.Refresh();
            LBox.DataContext = Data.View;

        }

        public static ObservableCollection<ItemViewModel> Items;
        public CollectionViewSource Data { get; set; }
        public string SearchText { get; set; }

        private void searchbox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            IEnumerable<ItemViewModel> match = Items.Where(i => i.Name.IndexOf(searchbox.Text, StringComparison.InvariantCultureIgnoreCase) > -1) as IEnumerable<ItemViewModel>;//Contains(searchbox.Text,StringComparer.OrdinalIgnoreCase)
            //string s;

            Data.Source = match;
            Data.View.Refresh();
            LBox.DataContext = Data.View;
        }
    }
}