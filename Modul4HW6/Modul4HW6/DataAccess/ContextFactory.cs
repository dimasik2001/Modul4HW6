using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Modul4HW6.Services;
using Modul4HW6.Services.Absractions;

namespace Modul4HW6.DataAccess
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private readonly IConfigService _config;
        public ContextFactory()
        {
            _config = new ConfigService();
        }
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(_config.ConnectionString);
            return new ApplicationDbContext(optionsBuilder.Options);
        }


    }
}
