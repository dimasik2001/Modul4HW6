using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        private readonly IEntityInsertService _insertService;
        public GenreConfiguration(IEntityInsertService insertService)
        {
            _insertService = insertService;
        }
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres").HasKey(t => t.Id);
            builder.Property(t => t.Title).IsRequired();
            builder.HasData(_insertService.GetGenres());
        }
    }
}
