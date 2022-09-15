using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public class MockPLDataStore : PLDataStore<Note>
    {
        private static readonly List<string> mockCources;
        private static readonly List<Note> mockNotes;
        private static int NextNote;

        static MockPLDataStore()
        {
            mockCources = new List<string>
            {
                "The Curse Of St. Anne’s Well",
                "Jacques De Molay’s Malediction",
                "The Curse Of King Casimir",
                "Commercial Rivalry Curses",
                "Broken Assyrian Stele",
                "The City That Jesus Cursed",
                "The Wrath Of The Fairies",
                "The Croesus Treasure’s Trail Of Misery",
            };

            mockNotes = new List<Note>
            {
                  new Note {Id ="1",  Heading ="1  Code", Text ="Xamarin 1  ", Course= mockCources[0]},
                  new Note {Id ="2",  Heading ="2  Code", Text ="Xamarin 2  ", Course= mockCources[1]},
                  new Note {Id ="3",  Heading ="3  Code", Text ="Xamarin 3  ", Course= mockCources[2]},
                  new Note {Id ="4",  Heading ="4  Code", Text ="Xamarin 4  ", Course= mockCources[3]},
                  new Note {Id ="5",  Heading ="5  Code", Text ="Xamarin 5  ", Course= mockCources[4]},
                  new Note {Id ="6",  Heading ="6  Code", Text ="Xamarin 6  ", Course= mockCources[5]},
                  new Note {Id ="7",  Heading ="7  Code", Text ="Xamarin 7  ", Course= mockCources[6]},
                  new Note {Id ="8",  Heading ="8  Code", Text ="Xamarin 8  ", Course= mockCources[0]},
                  new Note {Id ="9",  Heading ="9  Code", Text ="Xamarin 9  ", Course= mockCources[2]},
                  new Note {Id ="10", Heading ="10 Code", Text ="Xamarin 10 ", Course= mockCources[5]}

            };
        }

        public Task<string> AddNoteAsync(Note model)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetCourseAsync()
        {
            return Task.FromResult(mockCources);
        }
         
        public async Task<IEnumerable<Note>> GetNotesAsync(bool forceRefresh = false)
        {
            try
            {
                return await Task.FromResult(mockNotes); 
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }


        public Task<bool> UpdateNoteAsync(Note model)
        {
            throw new NotImplementedException();
        }
    }
}
