﻿using Microsoft.Maui.Controls;
using MauiApp1;
namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
