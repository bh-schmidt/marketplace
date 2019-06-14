using Marketplace.Domain.Entities.Products;
using System.Data.Entity.ModelConfiguration;

namespace Marketplace.Infra.Data.EntityConfig
{
    class ProductItemConfiguration : EntityTypeConfiguration<ProductItem>
    {
        public ProductItemConfiguration()
        {
            HasKey(p => new { p.ProductId, p.CartId });

            Property(p => p.ProductId)
                .IsRequired();

            Property(p => p.CartId)
                .IsRequired();

            Property(p => p.Quantity)
                .IsRequired();

            HasRequired(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId);

            HasRequired(p => p.Cart)
                .WithMany()
                .HasForeignKey(p => p.CartId);
        }
    }
}
