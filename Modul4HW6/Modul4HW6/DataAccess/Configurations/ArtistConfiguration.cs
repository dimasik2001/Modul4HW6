using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        private readonly IEntityInsertService _insertService;
        public ArtistConfiguration(IEntityInsertService insertService)
        {
            _insertService = insertService;
        }
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artists").HasKey(p => p.Id);
            builder.Property(t => t.DateOfBirth).IsRequired();
            builder.Property(t => t.Name).IsRequired();
            builder.HasData(_insertService.GetArtist());
        }
    }
}
