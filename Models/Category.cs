using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Self-relationship (Parent/Child categories)
        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> Subcategories { get; set; }

        // Relationships
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<DiscountCategory> DiscountCategories { get; set; }
    }
}
