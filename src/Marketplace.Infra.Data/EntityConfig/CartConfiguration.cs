using Marketplace.Domain.Entities.Products;
using System.Data.Entity.ModelConfiguration;

namespace Marketplace.Infra.Data.EntityConfig
{
    class CartConfiguration : EntityTypeConfiguration<Cart>
    {
        public CartConfiguration()
        {
            HasKey(c => c.CartId);

            HasMany(c => c.ProductItems);
        }
    }
}
