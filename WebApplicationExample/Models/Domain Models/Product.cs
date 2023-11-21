using System.Collections;
using System.Collections.Generic;

namespace WebApplicationExample.Models.Domain_Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ProductItem> ProductItems { get; set; }
    }
}
