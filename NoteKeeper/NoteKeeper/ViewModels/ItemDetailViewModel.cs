using NoteKeeper.Models;
using NoteKeeper.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {

        public Note Note { get; set; }
        public IList<string> Courses { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            asyncInitializeCurseList();

            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for note in viewModel",
                Course = Courses[0]
                
            };
        }

        private async void asyncInitializeCurseList()
        {
            var pldataSture = new MockPLDataStore();
            Courses = await pldataSture.GetCourseAsync();
        }
    }
}
