﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using gEtMeOut.Models;
using System;

namespace gEtMeOut.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            OptionsBuilder.UseSqlServer(configuration["ConnectionStrings:UserConnection"]);
        }

        public DbSet<User> User { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<Location> Locatie { get; set; }

        public DbSet<FavEvent> FavEvent { get; set; }

    }
}
