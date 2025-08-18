using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Variation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Price { get; set; }

        // Relationship with Product
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<DiscountVariation> DiscountVariations { get; set; }
    }
}
