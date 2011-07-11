using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;

namespace LearningWpf.ViewModels
{
    public class ShellViewModel
    {
        public ShellViewModel()
        {
            MenuItems = BuildMenu();
        }

        private ObservableCollection<MenuItem> BuildMenu()
        {
            var list = new ObservableCollection<MenuItem>();
            list.Add(new MenuItem { Header = "Header1", Command = new DelegateCommand<object>(OnCommand), ImageSource = @"Images\LargeIcon.png" });

            return list;
        }

        private void OnCommand(object o)
        {
            MenuItems.Add(new MenuItem { Header = "Header1", Command = new DelegateCommand<object>(OnCommand), ImageSource = @"Images\LargeIcon.png" });
        }

        public ObservableCollection<MenuItem> MenuItems { get; set; }
    }

    public class MenuItem
    {
        public string Header { get; set; }
        public ICommand Command { get; set; }
        public string ImageSource { get; set; }
    }
}
