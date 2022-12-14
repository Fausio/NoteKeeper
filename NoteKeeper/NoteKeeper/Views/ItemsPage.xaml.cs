using NoteKeeper.Models;
using NoteKeeper.Setup;
using NoteKeeper.ViewModels;
using NoteKeeper.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        #region ctor
        public ItemsPage()
        {
            InitializeComponent(); 
          
            BindingContext = _viewModel = new ItemsViewModel();
        }
        #endregion


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}