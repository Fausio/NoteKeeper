using NoteKeeperWithMasterDetail.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NoteKeeperWithMasterDetail.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}