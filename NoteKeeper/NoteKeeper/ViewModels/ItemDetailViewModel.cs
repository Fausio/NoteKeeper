using NoteKeeper.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteKeeper.ViewModels
{ 
    public class ItemDetailViewModel : BaseViewModel
    {

        public Note Note { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for note in viewModel"
            };
        }
    }
}
