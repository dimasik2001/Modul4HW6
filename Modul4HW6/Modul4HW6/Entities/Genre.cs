using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4HW6.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
