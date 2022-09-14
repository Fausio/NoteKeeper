﻿using NoteKeeper.Models;
using NoteKeeper.Services;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel; 
        

        #region ctor
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
           
            this.viewModel = viewModel;
            BindingContext = this.viewModel;
             
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            
            this.viewModel = new ItemDetailViewModel();
            BindingContext = this.viewModel; 
        }
        #endregion

 

        private void SaveItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Save", "Do you whant to save this item ?", "Continuar ➡️ ", "Cancelar ❌");
        }

    }
}