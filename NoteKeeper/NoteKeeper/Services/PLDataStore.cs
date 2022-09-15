using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public interface PLDataStore<T>
    {
         Task<String> AddNoteAsync(T model);
         Task<Boolean> UpdateNoteAsync(T model);
         Task<IEnumerable<T>> GetNotesAsync(bool forceRefresh = false);
        Task<List<String>> GetCourseAsync();
    }
}
