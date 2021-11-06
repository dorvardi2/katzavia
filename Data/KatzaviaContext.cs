using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Katzavia.Models;

namespace Katzavia.Data
{
    public class KatzaviaContext : DbContext
    {
        public KatzaviaContext(DbContextOptions<KatzaviaContext> options)
            : base(options)
        {
        }

        public DbSet<Katzavia.Models.User> User { get; set; }

        public DbSet<Katzavia.Models.Product> Product { get; set; }

        public DbSet<Katzavia.Models.Category> Category { get; set; }

        public DbSet<Katzavia.Models.Tags> Tags { get; set; }
        public DbSet<Katzavia.Models.Events> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "William",
                    Email = "aaa@aaa.com",
                    Password = "123456",
                    Type = UserType.Admin
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "William",
                    Desc = "sss",
                    Price = 6,
                    Image = ""
                }
            );
            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    Id = 1,
                    Name = "William",
                    myProducts = {}
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Williamaaa",
                    myProducts = { }
                }
            );
        }
    }
}
