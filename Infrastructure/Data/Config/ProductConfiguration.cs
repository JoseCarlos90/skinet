using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.Property(x => x.Id).IsRequired();
           builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
           builder.Property(x => x.Description).IsRequired().HasMaxLength(180);
           builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
           builder.Property(x => x.PictureUrl).IsRequired();
           builder.HasOne(b => b.ProductBrand).WithMany().HasForeignKey(p => p.ProductBrandId);
            builder.HasOne(b => b.ProductType).WithMany().HasForeignKey(p => p.ProductTypeId);
        }
    }
}