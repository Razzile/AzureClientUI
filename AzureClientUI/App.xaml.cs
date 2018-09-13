﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AzureClientUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            ConnectionManager manager = new ConnectionManager();

            ClientConnection client = manager.Connect("127.0.0.1", 1248);
            client.Run();

            var application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
