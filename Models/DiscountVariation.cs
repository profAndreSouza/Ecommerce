namespace Ecommerce.Models
{
    public class DiscountVariation
    {
        public int VariationId { get; set; }
        public Variation Variation { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
    }
}
