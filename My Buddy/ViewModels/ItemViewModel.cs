using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace My_Buddy.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel()
        {
            isFavorite = false;
            LastUsed = DateTime.Now;
        }

        public ItemViewModel(string name, string des)
        {
            Name = name;
            Description = des;
            isFavorite = false;
            LastUsed = DateTime.Now;
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public bool isImage { get; set; }
        public string Description { get; set; }
        public DateTime LastUsed { get; set; }
        public bool isFavorite { get; set; }
        public void setused() { LastUsed = DateTime.Now; }
        public override string ToString()
        {
            return Name;
        }
    }
}