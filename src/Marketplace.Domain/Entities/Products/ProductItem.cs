namespace Marketplace.Domain.Entities.Products
{
    public class ProductItem
    {
        public long ProductId { get; set; }
        public long CartId { get; set; }
        public double Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
