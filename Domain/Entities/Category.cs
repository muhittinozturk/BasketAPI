using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product>? Products { get; set; }  // Burada basit olsun diye bire çok yaptım.
                                                             // Olması gereken Çoka çok ilişki.

    }
}