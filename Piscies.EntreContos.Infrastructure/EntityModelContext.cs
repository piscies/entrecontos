using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Infrastructure
{
    public class EntityModelContext : DbContext
    {
        private IConfiguration Configuration { get; set; }

        public EntityModelContext(IConfiguration config)
        {
            Configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Configuration.GetConnectionString("mySqlAWS"));
        }

        public DbSet<Writer> Writer { get; set; }
    }
}
