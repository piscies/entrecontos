﻿using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseMySQL(Configuration.GetConnectionString("ECConnString"));
        }

        public DbSet<Writer> Writer { get; set; }
        public DbSet<Challenge> Challenge { get; set; }
        public DbSet<Classification> Classification { get; set; }
        public DbSet<ShortStory> ShortStory { get; set; }
    }
}
