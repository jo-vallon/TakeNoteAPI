namespace TakeNoteAPI.Core.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DoDate { get; set; }

    }
}