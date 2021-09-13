using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4HW6.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramURL { get; set; }
        public List<ArtistSong> ArtistSong { get; set; } = new List<ArtistSong>();
    }
}
