namespace WebApplicationExample.Models.Domain_Models
{
    public class ProductItem
    {
        public int ProductItemId { get; set; }
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
