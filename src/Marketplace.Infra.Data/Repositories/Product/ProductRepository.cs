using Marketplace.Domain.Entities.Products;
using Marketplace.Domain.Interfaces.Repositories.Products;

namespace Marketplace.Infra.Data.Repositories.Products
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
    }
}
