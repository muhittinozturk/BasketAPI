using Domain.Entities.Common;

namespace Domain.Entities
{
    public class BasketItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid BasketId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public Basket Basket { get; set; }
    }
}