using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4HW6.Entities
{
    public class ArtistSong
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int SongId { get; set; }
        public Artist Artist { get; set; }
        public Song Song { get; set; }
    }
}
