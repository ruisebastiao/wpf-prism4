﻿using System.Windows;

namespace LearningWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Configure Bootstrapper
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
