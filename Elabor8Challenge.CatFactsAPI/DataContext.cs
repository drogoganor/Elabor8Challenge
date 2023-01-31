using Elabor8Challenge.CatFactsAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

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
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var name1 = new Name
            {
                Id = "58e007480aac31001185ecef",
                First = "Jon",
                Last = "Arbuckle"
            };

            var user1 = new User
            {
                Id = "58e007480aac31001185ecef",
                NameId = "58e007480aac31001185ecef",
            };

            var factStatus1 = new FactStatus
            {
                Id = "58e007480aac31001185ecef",
                SentCount = 2,
                Verified = false,
            };

            var factStatus2 = new FactStatus
            {
                Id = "58e007480aac31001185ecea",
                SentCount = 7,
                Verified = true,
            };

            var createdDate = DateTime.Now;

            modelBuilder.Entity<Name>(b =>
            {
                b.HasData(name1);
            });

            modelBuilder.Entity<User>(b =>
            {
                b.HasData(user1);
            });

            modelBuilder.Entity<FactStatus>(b =>
            {
                b.HasData(factStatus1);
                b.HasData(factStatus2);
            });

            modelBuilder.Entity<CatFact>(b =>
            {
                b.HasData(new CatFact
                {
                    Id = "58e007480aac31001185ecef",
                    Text = "The frequency of a domestic cat's purr is the same at which muscles and bones repair themselves.",
                    CreatedAt = createdDate,
                    UpdatedAt = createdDate,
                    Deleted = false,
                    Source = FactSourceEnum.User,
                    Type = FactTypeEnum.Cat,
                    Upvotes = 12,
                    Used = true,
                    UserUpvoted = null,
                    V = 0,
                    UserId = user1.Id,
                    StatusId = factStatus1.Id
                });
                b.HasData(new CatFact
                {
                    Id = "58e007480aac31001185ecea",
                    Text = "By the time a cat is 9 years old, it will only have been awake for three years of its life.",
                    CreatedAt = createdDate,
                    UpdatedAt = createdDate,
                    Deleted = false,
                    Source = FactSourceEnum.User,
                    Type = FactTypeEnum.Cat,
                    Upvotes = 6,
                    Used = true,
                    UserUpvoted = null,
                    V = 2,
                    UserId = user1.Id,
                    StatusId = factStatus2.Id
                });
            });
        }

        public DbSet<CatFact> CatFacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<FactStatus> FactStatuses { get; set; }
    }
}
