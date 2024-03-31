using ef_npd211.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ef_npd211.Data
{
    public static class DbSeedExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
               // set Id value also for initialization
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Transport" },
                new Category() { Id = 3, Name = "Toys" },
                new Category() { Id = 4, Name = "Food & Drinks" },
                new Category() { Id = 5, Name = "Sport" },
                new Category() { Id = 6, Name = "Fashion" }
            });
        }
    }
}
