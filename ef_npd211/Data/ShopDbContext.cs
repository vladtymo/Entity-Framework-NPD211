using ef_npd211.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
            // set Id value also
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Transport" },
                new Category() { Id = 3, Name = "Toys" },
                new Category() { Id = 4, Name = "Food & Drinks" },
                new Category() { Id = 5, Name = "Sport" },
                new Category() { Id = 6, Name = "Fashion" }
            });

            // Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // collections (tables)
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
