using NoteKeeper.Models;
using NoteKeeper.Services;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
      
        public Note Note { get; set; }
        public IList<string> Courses { get; set; }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
            BindingContext = this.Note;
            NoteCurse.BindingContext = this;
        }
         
        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
            BindingContext = this.Note;
            NoteCurse.BindingContext = this;
        }

        private async void InitializeData()
        {

            var pldataSture = new MockPLDataStore();
            Courses = await pldataSture.GetCourseAsync();

            Note = new Note()
            {
                Heading = "Test note",
                Text = "Text for a test note"
            };
        }

        private void SaveItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Save", "Do you whant to save this item ?", "Continuar ➡️ ", "Cancelar ❌");
        }

    }
}