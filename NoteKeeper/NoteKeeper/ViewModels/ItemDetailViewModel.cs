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


        #region Props of NotificationPropertyChenges

        public string NoteCourse
        {
            get => Note.Course;
            set { Note.Course = value; OnPropertyChanged(); }

        }
        public string NoteText
        {
            get => Note.Text;
            set { Note.Text = value; OnPropertyChanged(); }

        }

        public string NoteHeading
        {
            get => Note.Heading;

            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }



        #endregion




        #region ctor
        public ItemDetailViewModel(Note item = null)
        {
            Title = item == null ? "New Note" : "Edit Note";
            asyncInitializeCurseList();

            Note = item ?? new Note();


        }
        #endregion


        private async void asyncInitializeCurseList()
        {
            var pldataSture = new MockPLDataStore();
            Courses = await pldataSture.GetCourseAsync();
        }
    }
}
