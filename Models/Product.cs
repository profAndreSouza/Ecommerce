using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }

        public virtual ICollection<Variation> Variations { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<DiscountProduct> DiscountProducts { get; set; }
    }
}
