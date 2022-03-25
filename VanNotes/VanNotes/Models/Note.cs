using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace VanNotes.Models
{
    internal class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
