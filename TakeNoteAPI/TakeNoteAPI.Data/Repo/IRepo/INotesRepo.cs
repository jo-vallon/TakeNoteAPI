using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNoteAPI.Core.Models;

namespace TakeNoteAPI.Data.Repo.IRepo
{
    public interface INotesRepo
    {
        Task<List<Note>> GetUserNotes();
    }
}
