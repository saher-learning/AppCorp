using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class AppCorpDbContext : IdentityDbContext<User>
    {
        public AppCorpDbContext(DbContextOptions
            <AppCorpDbContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Message> MessagesLog { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    AccessFailedCount = 0,
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );
            // Seeding Profiles 
            builder.Entity<Profile>().HasData(SeedData.SeedProfilesTable());


        }
    }
}
