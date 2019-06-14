using Marketplace.Domain.Entities.Products;
using Marketplace.Domain.Interfaces.Repositories.Products;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infra.Data.Repositories.Products
{
    public class ProductItemRepository : RepositoryBase<ProductItem>, IProductItemRepository
    {
        public async Task<IEnumerable<ProductItem>> GetByCartId(long id)
        {
            var result = Db.ProductItems.Include(p => p.Product).Where(p => p.CartId == id).ToListAsync();
            return await result;
        }
    }
}
