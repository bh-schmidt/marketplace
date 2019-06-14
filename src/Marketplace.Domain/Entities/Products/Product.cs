using System.Collections.Generic;

namespace Marketplace.Domain.Entities.Products
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual List<ProductItem> ProductItems { get; set; }
    }
}
