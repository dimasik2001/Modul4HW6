using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.Services
{
    public class EntityInsertService : IEntityInsertService
    {
        private Artist[] _artists;
        private Song[] _songs;
        private Genre[] _genres;
        private ArtistSong[] _artistSong;
        public EntityInsertService()
        {
            _genres = new Genre[]
            {
                new Genre()
                {
                    Id = 1,
                    Title = "Rock"
                },

                new Genre()
                {
                    Id = 2,
                    Title = "Hip-Hop"
                },

                new Genre()
                {
                    Id = 3,
                    Title = "Classic"
                },

                new Genre()
                {
                    Id = 4,
                    Title = "Ethno"
                },

                new Genre()
                {
                    Id = 5,
                    Title = "Pop"
                },
            };
            _songs = new Song[]
            {
                 new Song()
                 {
                    Id = 1,
                    Title = "The Final Countdown",
                    Duration = new TimeSpan(0, 5, 9),
                    ReleasedDate = new DateTime(1986, 6, 6),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Rock").Id
                 },

                 new Song()
                 {
                    Id = 2,
                    Title = "Rap God",
                    Duration = new TimeSpan(0, 6, 10),
                    ReleasedDate = new DateTime(2013, 10, 17),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Hip-Hop").Id
                 },

                 new Song()
                 {
                    Id = 3,
                    Title = "Zombie",
                    Duration = new TimeSpan(0, 5, 8),
                    ReleasedDate = new DateTime(1994, 6, 6),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Rock").Id
                 },

                 new Song()
                 {
                    Id = 4,
                    Title = "Love the Way You Lie",
                    Duration = new TimeSpan(0, 4, 27),
                    ReleasedDate = new DateTime(2010, 7, 8),
                    GenreId= _genres.FirstOrDefault(t => t.Title == "Hip-Hop").Id
                 },

                 new Song()
                 {
                    Id = 5,
                    Title = "Ethnic Track",
                    Duration = new TimeSpan(0, 10, 8),
                    ReleasedDate = new DateTime(1955, 6, 6),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Ethno").Id
                 },

                 new Song()
                 {
                    Id = 6,
                    Title = "Cadillac",
                    Duration = new TimeSpan(0, 2, 50),
                    ReleasedDate = new DateTime(2020, 7, 16),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Pop").Id
                 },

                 new Song()
                 {
                    Id = 7,
                    Title = "Lacrimosa",
                    Duration = new TimeSpan(0, 3, 10),
                    ReleasedDate = new DateTime(1791, 7, 16),
                    GenreId = _genres.FirstOrDefault(t => t.Title == "Classic").Id
                 },
            };
            _artists = new Artist[]
            {
                new Artist()
                {
                    Id = 1,
                    Name = "Mozart",
                    DateOfBirth = new DateTime(1756, 1, 27),
                },

                new Artist()
                {
                    Id = 2,
                    Name = "Morgenstern",
                    DateOfBirth = new DateTime(1998, 2, 17),
                    Email = "morgenstern@gmail.com",
                    InstagramURL = "www.instagram.com/morgen_shtern",
                    Phone = "666-666"
                },

                 new Artist()
                {
                    Id = 3,
                    Name = "Eminem",
                    DateOfBirth = new DateTime(1972, 10, 17),
                    Email = "eninem@gmail.com",
                    InstagramURL = "www.instagram.com/eminem",
                    Phone = "123-231"
                },

                  new Artist()
                {
                    Id = 4,
                    Name = "Rihanna",
                    DateOfBirth = new DateTime(1988, 2, 20),
                    Email = "rihanna@gmail.com",
                    InstagramURL = "www.instagram.com/badgalrir",
                    Phone = "12-66-323"
                },

                  new Artist()
                {
                    Id = 5,
                    Name = "Dolores O'Riordan",
                    DateOfBirth = new DateTime(1971, 9, 6),
                },

                  new Artist()
                {
                    Id = 6,
                    Name = "Joey Tempest",
                    DateOfBirth = new DateTime(1963, 8, 19),
                    Phone = "8-800-555-35-35"
                },
            };
            _artistSong = new ArtistSong[]
            {
                new ArtistSong()
                {
                    Id = 1,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Dolores O'Riordan").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Zombie").Id
                },

                new ArtistSong()
                {
                    Id = 2,
                    ArtistId= _artists.FirstOrDefault(t => t.Name == "Joey Tempest").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "The Final Countdown").Id
                },

                new ArtistSong()
                {
                    Id = 3,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Mozart").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Lacrimosa").Id
                },

                new ArtistSong()
                {
                    Id = 4,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Eminem").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Rap God").Id
                },

                new ArtistSong()
                {
                    Id = 5,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Eminem").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Love the Way You Lie").Id
                },

                new ArtistSong()
                {
                    Id = 6,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Rihanna").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Love the Way You Lie").Id
                },

                new ArtistSong()
                {
                    Id = 7,
                    ArtistId = _artists.FirstOrDefault(t => t.Name == "Morgenstern").Id,
                    SongId = _songs.FirstOrDefault(t => t.Title == "Cadillac").Id
                },
            };
        }

        public Artist[] GetArtist() => _artists;
        public Song[] GetSongs() => _songs;
        public Genre[] GetGenres() => _genres;
        public ArtistSong[] GetArtistSong() => _artistSong;
    }
}
