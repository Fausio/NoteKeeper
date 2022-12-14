using NoteKeeper.Setup;
using NoteKeeper.ViewModels;
using NoteKeeper.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NoteKeeper
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoute.Register_Route();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
