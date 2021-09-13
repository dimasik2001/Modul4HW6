using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.DataAccess;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6
{
    public class Starter
    {
        private DbContextOptions<ApplicationDbContext> _options;
        private readonly IConfigService _config;
        public Starter(IConfigService config)
        {
            _config = config;
            _options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(config.ConnectionString).Options;
        }
        public void Run()
        {
            using var db = new ApplicationDbContext(_options);
            var songs = db.Songs.Include(s => s.ArtistSong).Include(s => s.Genre);
            var artistSong = db.ArtistSong.Include(artsng => artsng.Artist).Include(artsng => artsng.Song);
            var genres = db.Genres.Include(g => g.Songs);

            // task 1
              var result1 = artistSong.Select(t => new { Song = t.Song.Title, Artist = t.Artist.Name, Genre = t.Song.Genre.Title }).Where(t => t.Genre != null).ToList();

            // task 2
             var result2 = genres.Select(t => new { Genre = t.Title, Count = t.Songs.Count }).ToList();

            // task 3
            var result3 = songs.Where(t => t.ReleasedDate < db.Artists.Max(s => s.DateOfBirth)).Select(a => new {Genre = a.Genre}).ToList();
        }
    }
}
