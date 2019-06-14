using System.Collections.Generic;

namespace Marketplace.Domain.Entities.Products
{
    public class Cart
    {
        public long CartId { get; set; }
        public List<ProductItem> ProductItems { get; set; }
    }
}
