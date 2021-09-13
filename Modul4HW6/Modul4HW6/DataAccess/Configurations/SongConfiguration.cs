using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        private readonly IEntityInsertService _insertService;
        public SongConfiguration(IEntityInsertService insertService)
        {
            _insertService = insertService;
        }
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs").HasKey(p => p.Id);
            builder.Property(t => t.Duration).IsRequired().HasConversion(duration => duration.Ticks, ticks => new TimeSpan(ticks));
            builder.Property(t => t.Title).IsRequired();
            builder.Property(t => t.ReleasedDate).IsRequired();
            builder.HasData(_insertService.GetSongs());
        }
    }
}
