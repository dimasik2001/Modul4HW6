using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess.Configurations
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        private readonly IEntityInsertService _insertService;
        public ArtistSongConfiguration(IEntityInsertService insertService)
        {
            _insertService = insertService;
        }
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ArtistId).IsRequired();
            builder.Property(t => t.SongId).IsRequired();
            builder.HasData(_insertService.GetArtistSong());
        }
    }
}
