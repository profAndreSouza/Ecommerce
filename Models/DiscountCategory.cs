namespace Ecommerce.Models
{
    public class DiscountCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
    }
}
