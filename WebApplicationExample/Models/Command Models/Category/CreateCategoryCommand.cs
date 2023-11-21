using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Category
{
    public class CreateCategoryCommand
    {
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
