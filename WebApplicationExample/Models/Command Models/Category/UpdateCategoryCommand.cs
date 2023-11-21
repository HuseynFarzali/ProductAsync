using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Category
{
    public class UpdateCategoryCommand
    {
        [Required]
        [Display(Name = "New Category Name")]
        public string Name { get; set; }
    }
}
