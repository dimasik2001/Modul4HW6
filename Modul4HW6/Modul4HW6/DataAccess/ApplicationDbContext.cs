using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.DataAccess.Configurations;
using Modul4HW6.Entities;
using Modul4HW6.Services;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IEntityInsertService _insertService;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _insertService = new EntityInsertService();
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ArtistSong> ArtistSong { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration(_insertService));
            modelBuilder.ApplyConfiguration(new SongConfiguration(_insertService));
            modelBuilder.ApplyConfiguration(new GenreConfiguration(_insertService));
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration(_insertService));
        }
    }
}
