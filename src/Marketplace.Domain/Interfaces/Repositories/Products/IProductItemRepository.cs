using Marketplace.Domain.Entities.Products;
using Marketplace.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Domain.Interfaces.Repositories.Products
{
    public interface IProductItemRepository : IRepositoryBase<ProductItem>
    {
        Task<IEnumerable<ProductItem>> GetByCartId(long id);
    }
}
