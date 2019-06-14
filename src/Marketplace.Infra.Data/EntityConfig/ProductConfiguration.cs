using Marketplace.Domain.Entities.Products;
using System.Data.Entity.ModelConfiguration;

namespace Marketplace.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(300);

            Property(p => p.Active)
                .IsRequired();
        }
    }
}
