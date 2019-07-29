using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using gEtMeOut.Models;

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

    }
}
