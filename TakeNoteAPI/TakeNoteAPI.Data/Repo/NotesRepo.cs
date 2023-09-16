using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNoteAPI.Core.Models;
using TakeNoteAPI.Data.Repo.IRepo;

namespace TakeNoteAPI.Data.Repo
{
    public class NotesRepo : INotesRepo
    {
        public Task<List<Note>> GetUserNotes()
        {
            throw new NotImplementedException();
        }
    }
}
