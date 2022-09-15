﻿using NoteKeeper.Services;
using NoteKeeper.Setup;
using NoteKeeper.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyServiceRegister.Dependency_ServiceRegister();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
         
    }
}
