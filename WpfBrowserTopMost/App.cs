﻿using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace WpfBrowserTopMost
{
    public class App : Application
    {
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
        }

        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}