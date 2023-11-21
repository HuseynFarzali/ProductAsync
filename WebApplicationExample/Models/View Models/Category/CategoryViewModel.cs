using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.View_Models.Category
{
    public class CategoryViewModel
    {
        [Display(Name = "Category ID")]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
