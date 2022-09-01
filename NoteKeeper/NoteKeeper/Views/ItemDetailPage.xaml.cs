using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Note Note { get; set; }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
            BindingContext = this.Note;
        }
         
        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
            BindingContext = this.Note; 
        }

        private void InitializeData()
        {
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