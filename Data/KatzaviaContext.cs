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
    }
}
