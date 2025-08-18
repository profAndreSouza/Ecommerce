using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Type { get; set; } // "percentage" or "fixed"
        public decimal Value { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DiscountProduct> DiscountProducts { get; set; }
        public virtual ICollection<DiscountVariation> DiscountVariations { get; set; }
        public virtual ICollection<DiscountCategory> DiscountCategories { get; set; }
    }
}
