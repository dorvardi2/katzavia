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
            //Console.WriteLine("called");
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
                    Id = 6,
                    Username = "Admin",
                    Email = "aaa@aaa.com",
                    Password = "123456",
                    Type = UserType.Admin
                }
            );

            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    Id = 1,
                    Name = "טרי",
                    myProducts = {}
                }
            );
            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    Id = 2,
                    Name = "קפוא",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "פרה",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 2,
                    Name = "כבש",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "שוקיים",
                   Image = "https://www.israelhayom.co.il/sites/default/files/styles/566x349/public/images/articles/2019/10/01/15699621369034_b.jpg",
                   Price = 6.0,
                   Desc = "נתח שוק טרי מהגולן",
                   myTags = { },
                   Category = { },
                   CategoryId = 1
               }
           );
        }
    }
}
