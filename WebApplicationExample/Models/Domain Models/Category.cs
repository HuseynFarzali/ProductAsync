using System.Collections;
using System.Collections.Generic;

namespace WebApplicationExample.Models.Domain_Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductItem> ProductItems { get; set; }
    }
}
