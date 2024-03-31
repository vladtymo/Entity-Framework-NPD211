using ef_npd211.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ef_npd211.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopEfNPD211;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(str);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            //DbSeedExtensions.Seed(modelBuilder);
            modelBuilder.Seed();

            // Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // collections (tables)
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
