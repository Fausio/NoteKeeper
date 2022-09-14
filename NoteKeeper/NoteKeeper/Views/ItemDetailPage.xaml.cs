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
        public IList<string> Courses { get; set; }

        #region ctor
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            this.viewModel.Note.Course = Courses[0];
            NoteCurse.BindingContext = this;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
            this.viewModel = new ItemDetailViewModel();
            BindingContext = this.viewModel;
            NoteCurse.BindingContext = this;
        }
        #endregion


        private async void InitializeData()
        {

            var pldataSture = new MockPLDataStore();
            Courses = await pldataSture.GetCourseAsync();

           
        }

        private void SaveItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Save", "Do you whant to save this item ?", "Continuar ➡️ ", "Cancelar ❌");
        }

    }
}