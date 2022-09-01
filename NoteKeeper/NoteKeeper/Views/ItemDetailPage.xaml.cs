using NoteKeeper.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();

        }

        private void SaveItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Save", "Do you whant to save this item ?", "Continuar ➡️ ", "Cancelar ❌");
        }
         
    }
}