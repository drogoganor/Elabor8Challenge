using Elabor8Challenge.CatFactsAPI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Elabor8Challenge.CatFactsAPI
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CatFact> CatFacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<FactStatus> FactStatuses { get; set; }
    }
}
