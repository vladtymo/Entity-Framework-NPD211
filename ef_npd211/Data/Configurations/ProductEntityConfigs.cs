using ef_npd211.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ef_npd211.Data.Configurations
{
    internal class ProductEntityConfigs : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Quantity).IsRequired(false);

            builder.Property(x => x.Discount).HasDefaultValue(0);

            // configure relationships
            // 1 - many
            builder.HasOne(x => x.Category).WithMany(x => x.Products)
                                            .HasForeignKey(x => x.CategoryId);

            // many - many
            builder.HasMany(x => x.Orders).WithMany(x => x.Products);
        }
    }
}
