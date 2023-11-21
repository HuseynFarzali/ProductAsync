using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace WebApplicationExample.Models.View_Models.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
