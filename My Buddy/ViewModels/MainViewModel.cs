using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using My_Buddy.Resources;
using System.Linq;
using System.IO.IsolatedStorage;

namespace My_Buddy.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        public ObservableCollection<ItemViewModel> Items {get; set; } 
        public ObservableCollection<ItemViewModel> LastUsed { get; set; }
        public static readonly IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            if (appSettings.Contains("All"))
            {
                Items = (ObservableCollection<ItemViewModel>)appSettings["All"];
            }
            else
            {
                Items.Add(new ItemViewModel("Chris Sells", "Chris Sells Live"));
                Items.Add(new ItemViewModel("Luka Abrus", "The Road to Redmond"));
                Items.Add(new ItemViewModel("Jim Hance", "The Best of Jim Hance"));
                appSettings["All"] = Items;
                appSettings.Save();
            }
            LastUsed = Items;
            LastUsed = new ObservableCollection<ItemViewModel>(LastUsed.OrderByDescending(i => i.LastUsed));
            // Sample data; replace with real data
            //this.Items.Add(new ItemViewModel("quadratic solver", "gives roots of a quadratic equation"));// { LineOne = "quadratic solver", LineTwo = "gives roots of a quadratic equation", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            //this.Items.Add(new ItemViewModel("2 variable solver", "solves a linear system in two variables"));// { LineOne = "2 variable solver", LineTwo = "solves a linear system in two variables", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            /*this.Items.Add(new ItemViewModel() { LineOne = "3 variable solver", LineTwo = "solves a linear system in three variables", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime four", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime five", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime six", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime seven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime eight", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime nine", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime ten", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime eleven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime twelve", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime thirteen", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime fourteen", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime fifteen", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime sixteen", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            */
            this.IsDataLoaded = true;
        }

        public void AddData(ItemViewModel item)
        {

            Items.Add(item);
            appSettings["All"] = Items;
            appSettings.Save();
            Items = (ObservableCollection<ItemViewModel>)appSettings["All"];
            LastUsed = Items;
            LastUsed = new ObservableCollection<ItemViewModel>(LastUsed.OrderByDescending(i => i.LastUsed));
        }
    }
}