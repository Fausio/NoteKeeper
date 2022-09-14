using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public interface PLDataStore
    {
         Task<String> AddNoteAsync(Note model);
         Task<Boolean> UpdateNoteAsync(Note model);
         Task<IList<Note>> GetNotesAsync();
         Task<List<String>> GetCourseAsync();
    }
}
